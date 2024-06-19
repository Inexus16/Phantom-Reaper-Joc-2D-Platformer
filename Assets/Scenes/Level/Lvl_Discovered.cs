using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl_Discovered : MonoBehaviour
{
    private int numberOfUnlockedLevels;
    public int leveltoUnlock;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            numberOfUnlockedLevels = PlayerPrefs.GetInt("levelsUnlocked");

            if (numberOfUnlockedLevels <= leveltoUnlock)
            {
                PlayerPrefs.SetInt("levelsUnlocked", numberOfUnlockedLevels + 1);
                PlayerPrefs.Save();
            }
        }
    }

}
