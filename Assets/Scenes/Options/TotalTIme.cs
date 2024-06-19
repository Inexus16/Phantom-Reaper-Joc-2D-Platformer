using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TotalTIme : MonoBehaviour
{
    public TMP_Text time;
    private void Start()
    {
        time.text = "Time: " + Timer.instance.ret_timeRemaining().ToString();
    }
}
