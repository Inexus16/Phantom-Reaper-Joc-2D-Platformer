using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;
    public TMP_Text coinText;
    public int currentCoins = 0;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        coinText.text = "Coins: " + currentCoins.ToString(); 
    }
    public void IncreaseCoins(int amount)
    {
        currentCoins += amount;
        coinText.text = "Coins: " + currentCoins.ToString();
    }
}
