using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{    
    public float mSpeed;
    private Rigidbody mRB;

    void Start()
    {
        mRB = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        mRB.velocity = new Vector3(horizontal, 0, vertical).normalized * mSpeed;        
    }
    
}
