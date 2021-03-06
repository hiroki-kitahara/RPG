using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RPG.Battle;

namespace RPG.Battle
{
	/// <summary>
	/// バトルシーンのルートコンポーネント.
	/// </summary>
	public class BattleSceneManager : Common.SceneRootBase
	{
		/// <summary>
		/// デバッグフラグ.
		/// </summary>
		[SerializeField]
		private bool isDebug;

		[SerializeField]
		private InitializeData debugInitializeData;

		void Start ()
		{
			if( isDebug )
			{
				SharedData.initializeData = debugInitializeData;
			}

			this.BroadcastMessage( this, MessageConstants.PreInitializeSystemMessage );
			this.BroadcastMessage( this, MessageConstants.StartBattleMessage );
		}
	}
}
