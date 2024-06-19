using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevel : MonoBehaviour
{
    public void OpenScene()
    {
        SceneManager.LoadScene("Level_" + PlayerPrefs.GetInt("LevelChoosen"));
    }
}
