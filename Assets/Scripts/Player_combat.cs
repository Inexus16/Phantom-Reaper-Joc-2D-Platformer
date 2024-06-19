using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_combat : MonoBehaviour
{
    [SerializeField] private AudioClip attackSound;
    [SerializeField] private AudioClip enemyHitSound;

    public Animator anim;
    public Transform attackPoint;
    //attack on layer
    public LayerMask enemyLayers;
    
    public int attackDamage = 40;
    public float attackRange = 0.5f;
    public float attackRate = 2f;
    float nextAttackTime = 1f;

    void Update()
    {
        if ((Time.time >= nextAttackTime))
        {

            if (Input.GetKeyDown(KeyCode.V))
            {
                Attack();
                nextAttackTime = Time.time + 1f /attackRate;
            }
        }
    }

    void Attack()
    {
        anim.SetTrigger("attack");
        SoundManager.instance.PlaySound(attackSound);
        Collider2D[] hitEnemies =  Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
            SoundManager.instance.PlaySound(enemyHitSound);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }


}
