// Copyright (c) Fathi Mokhtar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    #region Variables
    [SerializeField] float steerSpeed = 0.2f;
    [SerializeField] float moveSpeed = 0.01f;
    #endregion

    #region Unity Methods

    void Start()
    {

    }


    void Update()
    {
        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
    }

    #endregion

}
