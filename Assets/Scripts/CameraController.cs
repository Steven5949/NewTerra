using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform mPlayer;
    private Vector3 mOffset;
    
    void Start()
    {
        mOffset = transform.position - mPlayer.position;
    }
    void Update()
    {
        transform.position = mPlayer.position + mOffset;
    }
}
