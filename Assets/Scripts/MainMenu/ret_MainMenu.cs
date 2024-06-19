using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ret_MainMenu : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
    public void Retry()
    {
        SceneManager.LoadSceneAsync("Level_1");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Level_1()
    {
        SceneManager.LoadSceneAsync("Level_1");
    }
    public void Level_2()
    {
        SceneManager.LoadSceneAsync("Level_2");
    }
    public void Level_3()
    {
        SceneManager.LoadSceneAsync("Level_3");
    }
}
