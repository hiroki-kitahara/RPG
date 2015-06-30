﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace RPG.Battle
{
	/// <summary>
	/// コマンドIDが変更されたタイミングで特殊能力の説明テキストを設定するコンポーネント.
	/// </summary>
	public class OnModifiedCommandIdSetAbilityDescriptionText : MonoBehaviour
	{
		[SerializeField]
		private Text refText;

		[Attribute.MessageMethodReceiver( BattleMessageConstants.ModifiedCommandIdMessage )]
		void OnModifiedCommandId( int commandId )
		{
			Set( commandId );
		}

		[Attribute.MessageMethodReceiver( BattleMessageConstants.OpenCommandWindowMessage )]
		void OnOpenCommandWindow(BattleTypeConstants.CommandSelectType type)
		{
			Set( 0 );
		}

		private void Set( int index )
		{
			var allyInstanceData = BattleAllyPartyManager.Instance.Party.NoneCommandBattleMember.InstanceData;
			refText.text = Database.MasterData.Instance.GetAbilityData( allyInstanceData.abilityType, allyInstanceData.abilityList[index] ).Description;
		}
	}
}