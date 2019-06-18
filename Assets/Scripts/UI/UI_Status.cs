using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Status : MonoBehaviour
{
    public Text level;
    public Text money;
    public Image levelBar;

    private int prevLevel = -1;
    private int prevMoney = -1;
    private int prevExp = -1;

    void Update()
    {
        if (prevLevel != GameManager.instance.GetLevel())
        {
            level.text = "Lv. " + GameManager.instance.GetLevel() + " | " + GameManager.instance.GetLevelStatus();
            prevLevel = GameManager.instance.GetLevel();
        }
        if (prevMoney != GameManager.instance.GetMoney())
        {
            money.text = "" + GameManager.instance.GetMoney();
            prevMoney = GameManager.instance.GetMoney();
        }
        if (prevExp != GameManager.instance.GetExp())
        {
            levelBar.fillAmount = (float)GameManager.instance.GetExp() / GameManager.instance.GetMaxExp();
            prevExp = GameManager.instance.GetExp();
        }
    }
}