//Author: Fathi Mokhtar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    #region Variables
    [SerializeField] float steerSpeed = 150f;
    [SerializeField] float baseSpeed = 6.5f;
    [SerializeField] float slowSpeed = 5f;
    [SerializeField] float boostSpeed = 8f;

    float moveSpeed = 0f;

    #endregion

    #region Unity Methods

    void Start()
	{
        moveSpeed = baseSpeed;
	}
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSecondsRealtime(5f);
        //Car gets slowed for a certain amount of irl seconds
        moveSpeed = baseSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
	{
        if (other.tag == "Boost")
		{
            moveSpeed = boostSpeed;
            Debug.Log("Your car is speeding up!");
            StartCoroutine("Waiter");
		}
        if (other.tag == "Bump")
        {
            moveSpeed = slowSpeed;
            Debug.Log("Oh no! The car's be slowed down");
            StartCoroutine("Waiter");
        }
    }

    #endregion

}
