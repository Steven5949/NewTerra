using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndingCreditController : MonoBehaviour
{
    [SerializeField]
    private Button mMainMenuButton;

    void Start()
    {
        StartCoroutine(returnMainMenu());
        mMainMenuButton.onClick.AddListener(goToMainMenu);
    }

    public IEnumerator returnMainMenu()
    {
        yield return new WaitForSeconds(16.5f);
        SceneManager.LoadScene("MainMenu");
    }
    public void goToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
}
