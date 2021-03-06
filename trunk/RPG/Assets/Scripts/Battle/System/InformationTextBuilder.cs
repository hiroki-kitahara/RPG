using UnityEngine;
using System.Collections.Generic;

namespace RPG.Battle
{
	/// <summary>
	/// InformationTextDataから文字列を構築するコンポーネント.
	/// </summary>
	public static class InformationTextBuilder
	{
		public static string Build( InformationTextData data )
		{
			return StringAsset.Format( data.Key, FormatArguments( data ) );
		}
		
		private static object[] FormatArguments( InformationTextData data )
		{
			List<object> result = new List<object>();
			for( int i=0,imax=data.Parameter.Count; i<imax; i++ )
			{
				switch( data.Parameter[i] )
				{
				case TypeConstants.InformationParameterType.ExecuteCharacterName:
					result.Add( AllPartyManager.Instance.ActiveTimeMaxBattleCharacter.InstanceData.name );
					break;
				case TypeConstants.InformationParameterType.GiveDamage:
					result.Add( AllPartyManager.Instance.ActiveTimeMaxBattleCharacter.SelectCommandData.Impact.Damage );
					break;
				case TypeConstants.InformationParameterType.TargetName:
					result.Add( AllPartyManager.Instance.ActiveTimeMaxBattleCharacter.SelectCommandData.Impact.Target.InstanceData.name );
					break;
				case TypeConstants.InformationParameterType.AbilityName:
					result.Add( AllPartyManager.Instance.ActiveTimeMaxBattleCharacter.SelectCommandData.AbilityData.Name );
					break;
				case TypeConstants.InformationParameterType.AbilityShout:
					result.Add( AllPartyManager.Instance.ActiveTimeMaxBattleCharacter.SelectCommandData.AbilityData.Shout );
					break;
				case TypeConstants.InformationParameterType.ImpactStrength:
					result.Add( AllPartyManager.Instance.ActiveTimeMaxBattleCharacter.SelectCommandData.Impact.Strength );
					break;
				case TypeConstants.InformationParameterType.ImpactDefence:
					result.Add( AllPartyManager.Instance.ActiveTimeMaxBattleCharacter.SelectCommandData.Impact.Defence );
					break;
				case TypeConstants.InformationParameterType.ImpactSpeed:
					result.Add( AllPartyManager.Instance.ActiveTimeMaxBattleCharacter.SelectCommandData.Impact.Speed );
					break;
				}
			}
			return result.ToArray();
		}
	}
}
