using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Get_Level : MonoBehaviour
{
    public static string GetLevel;
    //public static string Next = NextLevel.NextLvl;

    private void Start()
    {
        GetLevel = Level.PreviousLevel;
    }
    public void LoadPreviousScene()
    {
        Debug.Log("Loading scene: " + GetLevel);
        SceneManager.LoadScene(GetLevel);
    }

}
