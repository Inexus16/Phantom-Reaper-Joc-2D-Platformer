using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TotalScore : MonoBehaviour
{
    public TMP_Text Score;
    private void Start()
    {
        int total;
        float fValue = Timer.instance.ret_timeRemaining();
        int iValue = Mathf.RoundToInt(fValue);
        int coin = CoinCounter.instance.currentCoins;
        if(coin == 0 )
            total = iValue * 1;
        else
            total = iValue * coin;

        if (!PlayerPrefs.HasKey("Lvl1_Score"))
        {
            PlayerPrefs.SetInt("Lvl1_Score", 0);
        }
        if (!PlayerPrefs.HasKey("Lvl2_Score"))
        {
            PlayerPrefs.SetInt("Lvl2_Score", 0);
        }
        if (!PlayerPrefs.HasKey("Lvl3_Score"))
        {
            PlayerPrefs.SetInt("Lvl3_Score", 0);
        }
        if (!PlayerPrefs.HasKey("Lvl4_Score"))
        {
            PlayerPrefs.SetInt("Lvl4_Score", 0);
        }
        if (!PlayerPrefs.HasKey("Lvl5_Score"))
        {
            PlayerPrefs.SetInt("Lvl5_Score", 0);
        }

        if (Level.PreviousLevel == "Level_1")
        {
            if (total > PlayerPrefs.GetInt("Lvl1_Score"))
                PlayerPrefs.SetInt("Lvl1_Score", total);
            Score.text = "Highscore: " + PlayerPrefs.GetInt("Lvl1_Score");
        }
        if (Level.PreviousLevel == "Level_2")
        {
            if (total > PlayerPrefs.GetInt("Lvl2_Score"))

                PlayerPrefs.SetInt("Lvl2_Score", total);
            Score.text = "Highscore: " + PlayerPrefs.GetInt("Lvl2_Score");
        }
        if (Level.PreviousLevel == "Level_3")
        {
            if (total > PlayerPrefs.GetInt("Lvl3_Score"))
                PlayerPrefs.SetInt("Lvl3_Score", total);
            Score.text = "Highscore: " + PlayerPrefs.GetInt("Lvl3_Score");
        }
        if (Level.PreviousLevel == "Level_4")
        {
            if (total > PlayerPrefs.GetInt("Lvl4_Score"))
                PlayerPrefs.SetInt("Lvl4_Score", total);
            Score.text = "Highscore: " + PlayerPrefs.GetInt("Lvl4_Score");
        }
        if (Level.PreviousLevel == "Level_5")
        {
            if (total > PlayerPrefs.GetInt("Lvl5_Score"))
                PlayerPrefs.SetInt("Lvl5_Score", total);
            Score.text = "Highscore: " + PlayerPrefs.GetInt("Lvl5_Score");
        }

    }
}
