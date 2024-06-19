using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowCurrentScore : MonoBehaviour
{
    public TMP_Text Score;
    private void Start()
    {
        int total;
        float fValue = Timer.instance.ret_timeRemaining();
        int iValue = Mathf.RoundToInt(fValue);
        int coin = CoinCounter.instance.currentCoins;
        if (coin == 0)
            total = iValue * 1;
        else
            total = iValue * coin;

        Score.text = "Score: " + total;
    }
}
