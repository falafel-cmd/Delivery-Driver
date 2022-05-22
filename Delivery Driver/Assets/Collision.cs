// Copyright (c) Fathi Mokhtar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

	#region Variables
	#endregion

	#region Unity Methods
	private void OnCollisionEnter2D(Collision2D other)
	{
		Debug.Log("You hit the imaginary rock!");
	}
	#endregion

}
