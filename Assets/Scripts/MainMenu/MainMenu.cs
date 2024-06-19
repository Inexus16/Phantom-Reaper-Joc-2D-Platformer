using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level_Choice");
    }
    public void Options()
    {
        SceneManager.LoadSceneAsync("OptionsMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void ChooseLvl()
    {
        SceneManager.LoadScene("Level_Choice 1");
    }

}
