using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RPG.Common;

namespace RPG.Battle
{
	/// <summary>
	/// 味方パーティデータ管理者コンポーネント.
	/// </summary>
	public class BattleAllyPartyManager : A_Singleton<BattleAllyPartyManager>
	{
		public Party Party{ private set; get; }

		void Awake()
		{
			Instance = this;
		}

#if DEBUG
		void Update()
		{
			this.Party.List.ForEach( a => a.DrawDebugText() );
		}
#endif

		[Attribute.MessageMethodReceiver( MessageConstants.PreInitializeSystemMessage )]
		void OnPreInitializeSystem()
		{
			this.Party = new Party();

			var initializeData = SharedData.initializeData.PlayerDataList;
			for( int i=0,imax=initializeData.Count; i<imax; i++ )
			{
				var data = Database.MasterData.Instance.Ally.ElementList[initializeData[i]];
				this.Party.Add( new Ally( data.characterData ) );
			}
		}
	}
}
