using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Level_choice : MonoBehaviour
{
    public int choice;
    public TMP_Text Score;

    public void ScoreLvl_1()
    {
        Score.text = "HighScore: " + PlayerPrefs.GetInt("Lvl1_Score");
    }
    public void ScoreLvl_2()
    {
        Score.text = "HighScore: " + PlayerPrefs.GetInt("Lvl2_Score");
    }
    public void ScoreLvl_3()
    {
        Score.text = "HighScore: " + PlayerPrefs.GetInt("Lvl3_Score");
    }
    public void ScoreLvl_4()
    {
        Score.text = "HighScore: " + PlayerPrefs.GetInt("Lvl4_Score");
    }
    public void ScoreLvl_5()
    {
        Score.text = "HighScore: " + PlayerPrefs.GetInt("Lvl5_Score");
    }
    public void SetChoice()
    {
        PlayerPrefs.SetInt("LevelChoosen" , choice);
    }

}
