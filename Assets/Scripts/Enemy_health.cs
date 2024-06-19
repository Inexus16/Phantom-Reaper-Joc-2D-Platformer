using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy_health : MonoBehaviour
{
    [SerializeField] private Slider slider;
    public void HealthUpdate(float health)
    {
        slider.value = health;
        if(health <= 0)
        {
            slider.enabled = false;
            slider.gameObject.SetActive(false);
        }
    }

}
