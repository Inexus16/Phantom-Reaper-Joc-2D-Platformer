using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private ParticleSystem testParticleSystem;
    public Transform objectToFollow;
    //[SerializeField] private AudioClip damageSoundClips;
    public Enemy_health healthbar;

    public Animator anim;
    public int maxHealth = 100;
    public int currentHealth;
    public float health;

    private void Start()
    {
        currentHealth = maxHealth;
        health = currentHealth;
        healthbar = GetComponent<Enemy_health>();

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        anim.SetTrigger("damage");

        testParticleSystem.transform.position = objectToFollow.position;
        testParticleSystem.Play();
        health = currentHealth;

        healthbar.HealthUpdate(health);

        //SoundManager.instance.PlaySound(damageSoundClips);
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("Enemy dead! ");
        anim.SetBool("dead", true);
        GetComponent<Rigidbody2D>().simulated = false;
    }
}
