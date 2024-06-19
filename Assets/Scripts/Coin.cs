using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value;
    [SerializeField] private AudioClip coin_sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            SoundManager.instance.PlaySound(coin_sound);
            Destroy(gameObject);
            CoinCounter.instance.IncreaseCoins(value);
        }
    }
}
