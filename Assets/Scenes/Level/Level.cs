using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public static string PreviousLevel { get; private set; }
    private void OnDestroy()
    {
        //PreviousLevel = gameObject.scene.name;
    }
    private void Start()
    {
        PreviousLevel = gameObject.scene.name;
        Debug.Log("we are at scene: " + Level.PreviousLevel);  
    }
}