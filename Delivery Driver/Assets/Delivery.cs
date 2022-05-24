// Copyright (c) Fathi Mokhtar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

	#region Variables
	#endregion

	#region Unity Methods
	private void OnCollisionEnter2D(Collision2D other)
	{
		Debug.Log("Ouch!");
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Package")
		{
			Debug.Log("Picked up the Package!");
		}

		if (other.tag == "Customer")
		{
			Debug.Log("Dropped off the Package!");
		}
	}
	#endregion

}
