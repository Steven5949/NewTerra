using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosTile : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.transform.position = new Vector3(0,2,0);
        }
    }
}
