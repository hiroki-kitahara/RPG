/*===========================================================================*/
/*
*     * FileName    : StringAssetUtility.cs
*
*     * Description : StringAssetユーティリティ.
*
*     * Author      : Hiroki_Kitahara.
*/
/*===========================================================================*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace RPG.Common
{
	/// <summary>
	/// StringAssetユーティリティ.
	/// </summary>
	public static class StringAssetUtility
	{
		public static string AbilityName( Battle.TypeConstants.CommandType type )
		{
			string[] s =
			{
				"Ability_None",
				"Ability_Magic",
				"Ability_Sumo",
				"Ability_Steal",
			};

			return StringAsset.Get( s[(int)type - (int)Battle.TypeConstants.CommandType.NoSkill] );
		}
	}
}
