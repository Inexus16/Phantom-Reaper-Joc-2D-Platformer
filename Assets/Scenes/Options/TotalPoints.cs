using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TotalPoints : MonoBehaviour
{
    public TMP_Text coinText;
    private void Start()
    {
        coinText.text = "Coins: " + CoinCounter.instance.currentCoins.ToString();
    }
}
