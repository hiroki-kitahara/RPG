/*===========================================================================*/
/*
*     * FileName    : LockRotation.cs
*
*     * Description : .
*
*     * Author      : Hiroki_Kitahara.
*/
/*===========================================================================*/
using UnityEngine;
using System.Collections;
using RPG.Common;

[ExecuteInEditMode()]
public class LockRotation : MonoBehaviour
{
	public Vector3 origin;

	[SerializeField]
	private bool applyX = true;
	
	[SerializeField]
	private bool applyY = true;
	
	[SerializeField]
	private bool applyZ = true;

	[SerializeField]
	private TypeConstants.UpdateType updateType = TypeConstants.UpdateType.LateUpdate;

	void Update()
	{
		if( updateType != TypeConstants.UpdateType.Update )
		{
			return;
		}

		Lock();
	}
	void LateUpdate()
	{
		if( updateType != TypeConstants.UpdateType.LateUpdate )
		{
			return;
		}
		
		Lock();
	}

	private void Lock()
	{
		var rotation = transform.rotation.eulerAngles;
		float x = applyX ? origin.x : rotation.x;
		float y = applyY ? origin.y : rotation.y;
		float z = applyZ ? origin.z : rotation.z;
		transform.rotation = Quaternion.Euler( x, y, z );
	}
}
