﻿/*===========================================================================*/
/*
*     * FileName    : BattleDebugTextMesh.cs
*
*     * Description : .
*
*     * Author      : Hiroki_Kitahara.
*/
/*===========================================================================*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RPG.Battle
{
	/// <summary>
	/// .
	/// </summary>
	public class BattleDebugTextMesh : MyMonoBehaviour
	{
		[SerializeField]
		private UILabel refLabel;

		[SerializeField]
		private BattleAllyPartyManager refAllyManager;

		[SerializeField]
		private BattleStateManager refStateManager;

		void Update()
		{
			StringBuilder builder = new StringBuilder();

			AppendState( builder );
			AppendAllyData( builder );

			refLabel.text = builder.ToString();
		}

		private void AppendState( StringBuilder builder )
		{
			builder.AppendLine( string.Format( "State = {0}", refStateManager.CurrentState ) );
		}

		private void AppendAllyData( StringBuilder builder )
		{
			var party = refAllyManager.Party;
			for( int i=0,imax=party.List.Count; i<imax; i++ )
			{
				builder.AppendLine( string.Format( "{0} ActiveTime = {1}", party.List[i].Data.name, party.List[i].ActiveTime ) );
			}
		}
	}
}