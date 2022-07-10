using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    private Vector3 mRotationSpeed;
    void Update()
    {
        transform.Rotate(mRotationSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            GameObject controllObj = GameObject.FindGameObjectWithTag("GameController");
            GameController controller = controllObj.GetComponent<GameController>();
            controller.addScore(1);
        }
    }
}
