﻿/*===========================================================================*/
/*
*     * FileName    : BattlePlayerCommandManager.cs
*
*     * Description : プレイヤーのコマンドを管理するコンポーネント.
*
*     * Author      : Hiroki_Kitahara.
*/
/*===========================================================================*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RPG.Common;

namespace RPG.Battle
{
	/// <summary>
	/// プレイヤーのコマンドを管理するコンポーネント.
	/// </summary>
	public class BattlePlayerCommandManager : MyMonoBehaviour
	{
		public class CommandData
		{
			public CharacterData Data{ private set; get; }

			public bool IsInput{ private set; get; }

			public CommandData( CharacterData data )
			{
				this.Data = data;
				this.IsInput = true;
			}
		}
		private List<CommandData> dataList = new List<CommandData>();

		[Attribute.MessageMethodReceiver( BattleMessageConstants.PreInitializeSystemMessage )]
		void OnPreInitializeSystem()
		{
			for( int i=0,imax=SharedData.initializeData.PlayerDataList.Count; i<imax; i++ )
			{
				this.dataList.Add( new CommandData( SharedData.initializeData.PlayerDataList[i] ) );
			}
		}
	}
}