// Copyright (c) Fathi Mokhtar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

	#region Variables
	bool hasPackage = false;
	[SerializeField] float deletionDelay = 1.0f;
	#endregion

	#region Unity Methods
	private void OnCollisionEnter2D(Collision2D other)
	{
		Debug.Log("Ouch!");
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Package" && hasPackage == false)
		{
			Debug.Log("Picked up the Package!");
			Destroy(this.gameObject, deletionDelay);
			hasPackage = true;
		}

		if (other.tag == "Customer")
		{
			if (hasPackage == true)
			{
				Debug.Log("Dropped off the Package!");
				hasPackage = false;
			} else
			{
				Debug.Log("You haven't picked up my package!");
			}
		}
	}
	#endregion

}
