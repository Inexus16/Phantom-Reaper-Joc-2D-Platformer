using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string previousLevel = Level.PreviousLevel;

    public void NextLVL()
    {
        string previousLevel = Level.PreviousLevel;

        int index = GetIndexFromLevelName(previousLevel);

        string nextLevel = "Level_" + (index + 1);

        SceneManager.LoadScene(nextLevel);

    }

    int GetIndexFromLevelName(string levelName)
    {
        string[] parts = levelName.Split('_');
        string indexStr = parts[parts.Length - 1];
        int index;
        if (int.TryParse(indexStr, out index))
        {
            return index;
        }
        else
        {
            Debug.LogError("Invalid level name format!");
            return -1;
        }
    }
}
