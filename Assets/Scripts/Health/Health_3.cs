using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health_3 : MonoBehaviour
{

    //on Player
    public HealthBar healthBar;
    [SerializeField] private AudioClip HearthSound;

    public int maxHealth = 100;
    public int currentHealth;
    private int temp;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
        if(currentHealth <= 0)
            SceneManager.LoadScene("DeathScreen");
    }

    public void TakeHealth(int health)
    {
        if(health + currentHealth <= maxHealth)
            currentHealth += health;
        else
        {
            temp = maxHealth - currentHealth;
            currentHealth += temp;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            //player takes damage
            TakeDamage(15);
        }
        if (collision.gameObject.layer == 13)
        {
            TakeDamage(maxHealth);
            SceneManager.LoadScene("DeathScreen");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Hearth"))
        {
            TakeHealth(50);
            healthBar.SetHealth(currentHealth);
            Destroy(collision.gameObject);
            SoundManager.instance.PlaySound(HearthSound);

        }
    }
}
