﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GameObject ctrObj = GameObject.FindGameObjectWithTag("GameController");
            GameController control = ctrObj.GetComponent<GameController>();
            control.isDead(1);
        }
    }
}
