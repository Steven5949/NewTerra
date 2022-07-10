using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineTile : MonoBehaviour
{
    [SerializeField]
    private int mDamage;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GameObject controllObj = GameObject.FindGameObjectWithTag("GameController");
            GameController controller = controllObj.GetComponent<GameController>();
            controller.loseLife(mDamage);
            gameObject.SetActive(false);
        }
    }
}
