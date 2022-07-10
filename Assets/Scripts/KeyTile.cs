using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTile : MonoBehaviour
{
    [SerializeField]
    private GameObject mDoor;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            mDoor.transform.position = Vector3.back;
            gameObject.SetActive(false);
        }
    }
}
