using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("Score");
    }
}
