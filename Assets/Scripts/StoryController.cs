using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class StoryController : MonoBehaviour
{
    [SerializeField]
    private Button mStoryButton;
    [SerializeField]
    private GameObject mStoryPannel;

    void Start()
    {
        Time.timeScale = 0;
        mStoryButton.onClick.AddListener(exitStory);
    }
    private void exitStory()
    {
        mStoryPannel.SetActive(false);
        Time.timeScale = 1;
    }
}
