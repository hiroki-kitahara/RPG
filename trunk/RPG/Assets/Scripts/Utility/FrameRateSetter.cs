﻿/*===========================================================================*/
/*
*     * FileName    :FrameRateSetter.cs
*
*     * Description : フレームレートを設定するコンポーネント.
*
*     * Author      : Hiroki_Kitahara.
*/
/*===========================================================================*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// フレームレートを設定するコンポーネント.
/// </summary>
public class FrameRateSetter : MyMonoBehaviour
{
	[SerializeField]
	private int delay;

	[SerializeField]
	private int frameRate;

	void Start ()
	{
		FrameRateUtility.StartCoroutine( this.delay, () => Application.targetFrameRate = this.frameRate );
	}
}
