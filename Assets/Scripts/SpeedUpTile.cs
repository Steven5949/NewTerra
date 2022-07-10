using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedUpTile : MonoBehaviour
{
    [SerializeField]
    private float mBoostSpeed;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            Player controller = playerObj.GetComponent<Player>();
            gameObject.SetActive(false);
            if (controller.mSpeed < 10)
            {
                controller.mSpeed += mBoostSpeed;
            }            
        }
    }
}
