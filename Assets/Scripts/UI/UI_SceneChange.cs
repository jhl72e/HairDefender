using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_SceneChange : MonoBehaviour
{

    public void ChangeMarketScene()
    {
        SceneManager.LoadScene("MarketScene");
    }

    public void ChangeGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
