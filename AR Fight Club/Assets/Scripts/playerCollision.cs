﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            fighterController.instance.react();
            Debug.Log("ENEMY HIT");
        }
    }
}
