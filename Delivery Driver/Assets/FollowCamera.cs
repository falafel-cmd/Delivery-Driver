// Copyright (c) Fathi Mokhtar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

	#region Variables
	[SerializeField] GameObject objectToFollow;
	#endregion

	#region Unity Methods

    void LateUpdate()
    {
		transform.position = objectToFollow.transform.position + new Vector3(0, 0, -10);
    }

	#endregion

}
