using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject mMainMenuPannel;
    [SerializeField]
    private Button mStartButton, mExitButton;
    [SerializeField]
    private GameObject mMapPanel;
    [SerializeField]
    private Button mStart1_1Button, mStart1_2Button
        , mStart1_3Button, mStart1_4Button, mStart1_5Button, mCancelButton;
    [SerializeField]
    private Button mInstructionButton;
    [SerializeField]
    private GameObject mInstructionPanel;
    [SerializeField]
    private Button mInstructionQuitButton;
    [SerializeField]
    private Button mCreditButton;
    [SerializeField]
    private GameObject mEndingCredit;
    void Start()
    {
        mStartButton.onClick.AddListener(mapListAction);
        mExitButton.onClick.AddListener(exitAction);
        mStart1_1Button.onClick.AddListener(startMap1_1Action);
        mStart1_2Button.onClick.AddListener(startMap1_2Action);
        mStart1_3Button.onClick.AddListener(startMap1_3Action);
        mStart1_4Button.onClick.AddListener(startMap1_4Action);
        mStart1_5Button.onClick.AddListener(startMap1_5Action);
        mCancelButton.onClick.AddListener(cancelAction);
        mInstructionButton.onClick.AddListener(instructionAction);
        mInstructionQuitButton.onClick.AddListener(instructionQuitAction);
        mCreditButton.onClick.AddListener(creditMovie);
    }
    
    public void mapListAction()
    {
        mMapPanel.SetActive(true);
    }
    public void exitAction()
    {
        Application.Quit();
    }
    public void startMap1_1Action()
    {
        SceneManager.LoadScene("1-1");
        Time.timeScale = 1;
    }
    public void startMap1_2Action()
    {
        SceneManager.LoadScene("1-2");
        Time.timeScale = 1;
    }
    public void startMap1_3Action()
    {
        SceneManager.LoadScene("1-3");
        Time.timeScale = 1;
    }
    public void startMap1_4Action()
    {
        SceneManager.LoadScene("1-4");
        Time.timeScale = 1;
    }
    public void startMap1_5Action()
    {
        SceneManager.LoadScene("1-5");
        Time.timeScale = 1;
    }
    public void cancelAction()
    {
        mMapPanel.SetActive(false);
    }
    public void instructionAction()
    {
        mInstructionPanel.SetActive(true);
    }
    public void instructionQuitAction()
    {
        mInstructionPanel.SetActive(false);
    }
    public void creditMovie()
    {
        SceneManager.LoadScene("Ending");
        Time.timeScale = 1;
    }
}
