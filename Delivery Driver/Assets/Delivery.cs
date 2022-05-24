// Copyright (c) Fathi Mokhtar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

	#region Variables
	bool hasPackage = false;

	[SerializeField] float deletionDelay = 0.5f;

	[SerializeField] Color32 hasPackageColor = new Color32(164, 98, 98, 255);
	[SerializeField] Color32 noPackageColor = new Color32(0, 0, 0, 255);

	SpriteRenderer spriteRenderer;

	#endregion

	#region Unity Methods

	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	private void OnCollisionEnter2D(Collision2D other)
	{
		Debug.Log("Ouch!");
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Package" && !hasPackage)
		{
			Debug.Log("Picked up the Package!");
			hasPackage = true;
			Destroy(other.gameObject, deletionDelay);
			spriteRenderer.color = hasPackageColor;
		}

		if (other.tag == "Customer")
		{
			if (hasPackage == true)
			{
				Debug.Log("Dropped off the Package!");
				hasPackage = false;
				spriteRenderer.color = noPackageColor;
			} else
			{
				Debug.Log("You haven't picked up my package!");
			}
		}
	}
	#endregion

}
