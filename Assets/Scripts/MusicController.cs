using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    [SerializeField]
    private Button mMusicButton;
    [SerializeField]
    private AudioSource mIU;
    [SerializeField]
    private Text mMusicText;
    void Start()
    {
        mMusicButton.onClick.AddListener(musicAction);
        mMusicText.text = "Music Off";
    }
    public void musicAction()
    {
        if (mIU.volume > 0)
        {
            mIU.volume = 0;
            mIU.Pause();
            mMusicText.text = "Music On";
        }
        else
        {
            mIU.volume = 0.1f;
            mIU.Play();
            mMusicText.text = "Music Off";
        }
    }
}
