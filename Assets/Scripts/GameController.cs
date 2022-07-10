using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private int mScore;
    [SerializeField]
    private int mClearScore;
    [SerializeField]
    private Text mScoreText;
    [SerializeField]
    private Text mTimeText;
    [SerializeField]
    private float mTimeSet;
    private float mCurrentTime;
    [SerializeField]
    private GameObject mBottom;
    [SerializeField]
    private GameObject mHeart1, mHeart2, mHeart3;
    private int mLife =3;

    public static GameController mInstance;

    [SerializeField]
    private GameObject mPausePannel;
    [SerializeField]
    private Button mPauseButton, mResumeButton, mRestartButton, mMainMenuButton;

    [SerializeField]
    private GameObject mIsClearedPannel;
    [SerializeField]
    private Text mFailText;
    [SerializeField]
    private Button mGotoRestartButton, mNextMapButton, mGotoMenuButton, mExitButton;
    [SerializeField]
    private String mMapName;

    private void Awake()
    {
        mInstance = this;
    }
    void Start()
    {
        mCurrentTime = mTimeSet;
        mScoreText.text = "Goal: 0 / " + mClearScore.ToString();

        mPauseButton.onClick.AddListener(pauseAction);
        mResumeButton.onClick.AddListener(resumeAction);
        mRestartButton.onClick.AddListener(restartAction);
        mMainMenuButton.onClick.AddListener(mainMenuAction);

        mGotoRestartButton.onClick.AddListener(restartAction);
        mNextMapButton.onClick.AddListener(nextMapButtonAction);
        mGotoMenuButton.onClick.AddListener(mainMenuAction);
        mExitButton.onClick.AddListener(exitAction);
    }
    private void Update()
    {
        mCurrentTime -= Time.deltaTime;
        mTimeText.text = string.Format("{0:0.#}", mCurrentTime);
        if(mCurrentTime <= 0 )
        {
            isDead(1);
        }
    }
    public void addScore(int value)
    {
        mScore += value;
        mScoreText.text = string.Format("Goal: {0} / {1}", mScore.ToString()
                                    , mClearScore.ToString());

        if(mScore >= mClearScore)
        {
            Time.timeScale = 0;
            mPauseButton.GetComponent<Button>().interactable = false;
            mIsClearedPannel.SetActive(true);
            if (mMapName.Equals("lastMap"))
            {
                mNextMapButton.interactable = false;
            }
        }
    }

    public void loseLife(int value)
    {
        mLife -= value;
        if(mLife == 1)
        {
            mHeart3.SetActive(false);
            mHeart2.SetActive(false);
        }
        else if(mLife == 2)
        {
            mHeart3.SetActive(false);
            
        }
        else if(mLife <= 0)
        {
            mHeart3.SetActive(false);
            mHeart2.SetActive(false);
            mHeart1.SetActive(false);
            isDead(1);
        }
    }

    public void pauseAction()
    {
        Time.timeScale = 0;
        mPauseButton.GetComponent<Button>().interactable = false;
        mPausePannel.SetActive(true);
    }
    public void resumeAction()
    {
        Time.timeScale = 1;
        mPauseButton.GetComponent<Button>().interactable = true;
        mPausePannel.SetActive(false);
    }
    public void restartAction()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void mainMenuAction()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void exitAction()
    {
        Application.Quit();
    }

    public void isDead(int val)
    {
        if(val == 1)
        {
            Time.timeScale = 0;
            //mCurrentTime = mTimeSet;
            mFailText.text = "Failed...";
            mPauseButton.GetComponent<Button>().interactable = false;
            mIsClearedPannel.SetActive(true);
            mNextMapButton.interactable = false;
        }
    }
    public void nextMapButtonAction()
    {
        SceneManager.LoadScene(mMapName);
        Time.timeScale = 1;
    }
}
