using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpTile : MonoBehaviour
{
    [SerializeField]
    private Transform mAnotherWarpPos;

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player") && Input.GetKeyDown(KeyCode.Space))
        {
            other.transform.position = mAnotherWarpPos.position;
        }
    }
}
