using UnityEngine;
using System.Collections.Generic;
using RPG.Common;

namespace RPG.Battle
{
	/// <summary>
	/// コマンド実行イベント時にコマンド実行クラスの終了処理を行うコンポーネント.
	/// </summary>
	public class OnExecuteCommandEndExecuteCommandExecutor : MyMonoBehaviour
	{
		[Attribute.MessageMethodReceiver( MessageConstants.ExecuteCommandMessage )]
		void OnExecuteCommand( MessageConstants.ExecuteCommandHook hook )
		{
			hook.Executer.End();
		}
	}
}
