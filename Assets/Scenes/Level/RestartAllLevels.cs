using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartAllLevels : MonoBehaviour
{
    public void ResetAllLevels()
    {
        PlayerPrefs.DeleteKey("Lvl1_Score");
        PlayerPrefs.DeleteKey("Lvl2_Score");
        PlayerPrefs.DeleteKey("Lvl3_Score");
        PlayerPrefs.DeleteKey("Lvl4_Score");
        PlayerPrefs.DeleteKey("Lvl5_Score");
        PlayerPrefs.DeleteKey("levelsUnlocked");

        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }
}
