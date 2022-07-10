using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeAttackCube : MonoBehaviour
{
    [SerializeField]
    private float mDropCount;

    void Update()
    {
        mDropCount -= Time.fixedDeltaTime;
        if(mDropCount <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
