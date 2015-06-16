﻿/*===========================================================================*/
/*
*     * FileName    : BattleTypeConstants.cs
*
*     * Author      : Hiroki_Kitahara.
*/
/*===========================================================================*/
using UnityEngine;
using System.Collections.Generic;

namespace RPG.Battle
{
	/// <summary>
	/// バトルで使用するタイプ定義.
	/// </summary>
	public class BattleTypeConstants
	{
		/// <summary>
		/// コマンドタイプ.
		/// </summary>
		public enum CommandType : int
		{
			/// <summary> 戦う. </summary>
			Attack,
			
			/// <summary> 道具. </summary>
			Item,
			
			/// <summary> 守る. </summary>
			Defence,
			
			/// <summary> かばう. </summary>
			CoverUp,
			
			/// <summary> 逃げる. </summary>
			Escape,
			
			/// <summary> 無し. </summary>
			None,
			
			/// <summary> 術. </summary>
			Magic,
			
			/// <summary> すもう技. </summary>
			Sumo,
			
			/// <summary> 盗む. </summary>
			Steal,
		}
		
		/// <summary>
		/// コマンド選択タイプ.
		/// </summary>
		public enum CommandSelectType : int
		{
			/// <summary> メインコマンド. </summary>
			Main,
			
			/// <summary> アイテム. </summary>
			Item,
			
			/// <summary> 味方. </summary>
			Ally,
			
			/// <summary> 敵. </summary>
			Enemy,
		}

		/// <summary>
		/// 情報文字列表示の引数タイプ.
		/// </summary>
		public enum InformationParameterType : int
		{
			/// <summary> コマンド実行者の名前. </summary>
			ExecuteMemberName,


		}
	}
}