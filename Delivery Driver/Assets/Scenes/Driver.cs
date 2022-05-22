// Copyright (c) Fathi Mokhtar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    #region Variables
    #endregion

    #region Unity Methods

    void Start()
    {

    }


    void Update()
    {
        //transform.Rotate(0, 0, 0.2f);
        transform.Translate(0, 0.01f, 0);
    }

    #endregion

}
