using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    [SerializeField]
    private GameObject mBridge;
    [SerializeField]
    private int mActiveTime;
    void Start()
    {
        StartCoroutine(bridgeBlink());
    }
    
    private IEnumerator bridgeBlink()
    {
        while(true)
        {
            yield return new WaitForSeconds(mActiveTime);
            mBridge.SetActive(false);
            yield return new WaitForSeconds(1);
            mBridge.SetActive(true);
        }
    }
}
