using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_SettingSound : MonoBehaviour
{
    public GameObject bgmOn, bgmOff;
    public GameObject sfxOn, sfxOff;

    void OnEnable()
    {
        if(GameManager.instance.isBGMplay == true)
        {
            bgmOn.SetActive(true);
            bgmOff.SetActive(false);
        }
        else
        {
            bgmOn.SetActive(false);
            bgmOff.SetActive(true);
        }

        if (GameManager.instance.isSFXplay == true)
        {
            sfxOn.SetActive(true);
            sfxOff.SetActive(false);
        }
        else
        {
            sfxOn.SetActive(false);
            sfxOff.SetActive(true);
        }
    }

    public void OnBGMclick()
    {
        if(GameManager.instance.isBGMplay == true)
        {
            bgmOn.SetActive(false);
            bgmOff.SetActive(true);
            GameManager.instance.isBGMplay = false;
        }
        else
        {
            bgmOn.SetActive(true);
            bgmOff.SetActive(false);
            GameManager.instance.isBGMplay = true;
        }
    }

    public void OnSFXclick()
    {
        if (GameManager.instance.isSFXplay == true)
        {
            sfxOn.SetActive(false);
            sfxOff.SetActive(true);
            GameManager.instance.isSFXplay = false;
        }
        else
        {
            sfxOn.SetActive(true);
            sfxOff.SetActive(false);
            GameManager.instance.isSFXplay = true;
        }
    }
}
