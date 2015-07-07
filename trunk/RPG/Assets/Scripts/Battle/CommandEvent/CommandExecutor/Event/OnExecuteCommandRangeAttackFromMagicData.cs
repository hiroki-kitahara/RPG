using UnityEngine;
using System.Collections.Generic;

namespace RPG.Battle
{
	/// <summary>
	/// コマンド実行イベント時に術データから範囲ダメージを与えるコンポーネント.
	/// </summary>
	public class OnExecuteCommandRangeAttackFromMagicData : MyMonoBehaviour, I_OnExecuteCommandHookable
	{
		[Attribute.MessageMethodReceiver( MessageConstants.ExecuteCommandMessage )]
		public void OnExecuteCommand(Battle.MessageConstants.ExecuteCommandHook hook)
		{
			var executer = AllPartyManager.Instance.ActiveTimeMaxBattleCharacter;
			var selectCommandData = executer.SelectCommandData;
			var magicData = selectCommandData.AbilityData as Database.MagicData;

			Debug.Assert(
				magicData != null,
				string.Format(
					"術ではありません. 実行者 = {0} 特殊能力タイプ = {1} ID = {2}",
					executer.InstanceData.name,
					selectCommandData.Type,
					selectCommandData.AbilityData.ID
				));

			selectCommandData.Impact.Damage = CalcurateDamage.Range( magicData.minPower, magicData.maxPower );
			selectCommandData.Impact.Target.TakeDamage( selectCommandData.Impact.Damage );
		}
	}
}
