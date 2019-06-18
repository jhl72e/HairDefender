using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool isBGMplay;
    public bool isSFXplay;

    private int money;
    private int level;

    private int exp;
    private int maxExp;

    public int hairColor;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        EncryptedPlayerPrefs.keys = new string[5];
        EncryptedPlayerPrefs.keys[0] = "jD9kp3Xc";
        EncryptedPlayerPrefs.keys[1] = "OVndpA16";
        EncryptedPlayerPrefs.keys[2] = "mn409VnQ";
        EncryptedPlayerPrefs.keys[3] = "62VbmaPw";
        EncryptedPlayerPrefs.keys[4] = "0N8WfxzI";

        GameInit();
    }

    void OnDestroy()
    {
        SaveGameData();
    }

    void GameInit()
    {
        Screen.SetResolution(Screen.width, Screen.width * 16 / 9, true);
        
        LoadGameData();
    }

    void SaveGameData()
    {
        if (isBGMplay)
        {
            EncryptedPlayerPrefs.SetInt("isBGMplay", 1);
        }
        else
        {
            EncryptedPlayerPrefs.SetInt("isBGMplay", 0);
        }

        if (isSFXplay)
        {
            EncryptedPlayerPrefs.SetInt("isSFXplay", 1);
        }
        else
        {
            EncryptedPlayerPrefs.SetInt("isSFXplay", 0);
        }

        EncryptedPlayerPrefs.SetInt("money", money);

        EncryptedPlayerPrefs.SetInt("level", level);

        EncryptedPlayerPrefs.SetInt("exp", exp);

        EncryptedPlayerPrefs.SetInt("hairColor", hairColor);

        PlayerPrefs.Save();
    }

    void LoadGameData()
    {
        int temBGMplay = EncryptedPlayerPrefs.GetInt("isBGMplay", 1);
        if (temBGMplay == 1)
        {
            isBGMplay = true;
        }
        else
        {
            isBGMplay = false;
        }

        int temSFXplay = EncryptedPlayerPrefs.GetInt("isSFXplay", 1);
        if (temSFXplay == 1)
        {
            isSFXplay = true;
        }
        else
        {
            isSFXplay = false;
        }

        money = EncryptedPlayerPrefs.GetInt("money", 0);

        level = EncryptedPlayerPrefs.GetInt("level", 1);

        exp = EncryptedPlayerPrefs.GetInt("exp", 0);
        maxExp = level * 100;

        hairColor = EncryptedPlayerPrefs.GetInt("hairColor", 0);
    }

    public int GetMoney()
    {
        return money;
    }

    public void AddMoney(int num)
    {
        money += num;
    }

    public int GetLevel()
    {
        return level;
    }

    public int GetExp()
    {
        return exp;
    }
    public int GetMaxExp()
    {
        return maxExp;
    }

    public void AddExp(int num)
    {
        exp += num;
        if(exp >= maxExp)
        {
            level++;
            exp -= maxExp;
            maxExp = level * 100;
        }
        else if(exp < 0)
        {
            if(level == 1)
            {
                //게임오버
            }
            else
            {
                level--;
                maxExp = level * 100;
                exp += maxExp;
            }
        }
    }

    public string GetLevelStatus()
    {
        switch (level)
        {
            case 1:
                return "푸석푸석한 두피";
            case 2:
                return "";
            case 3:
                return "";
            case 4:
                return "";
            case 5:
                return "";
            case 6:
                return "";
            case 7:
                return "";
            default:
                return "";
        }
    }

    public void ChangeHairColor(int num)
    {
        hairColor = num;
    }
}
