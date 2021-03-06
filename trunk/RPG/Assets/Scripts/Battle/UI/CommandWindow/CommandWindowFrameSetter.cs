using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace RPG.Battle
{
	/// <summary>
	/// コマンド選択ウィンドウのフレームのスケール値を設定するコンポーネント.
	/// </summary>
	public abstract class CommandWindowFrameSetter : MyMonoBehaviour
	{
		[SerializeField]
		private RectTransform refRectTransform;

		[SerializeField]
		private TypeConstants.CommandSelectType commandSelectType;

		[SerializeField]
		private int defaultScale;
		
		[SerializeField]
		private int addScale;
		
		[Attribute.MessageMethodReceiver( MessageConstants.OpenCommandWindowMessage )]
		void OnOpenCommandWindow( TypeConstants.CommandSelectType type )
		{
			if( type != commandSelectType )	return;

			var rect = refRectTransform.rect;
			this.refRectTransform.sizeDelta = new Vector2(rect.width, defaultScale + addScale * ElementCount);
		}

		protected abstract int ElementCount{ get; }
	}
}
