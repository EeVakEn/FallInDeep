using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health = 1;
    public int killReward = 5;
    public GameObject effect;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        anim.SetTrigger("isEnemy");

        if (health <= 0)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Die();
            CoinManager.instance.ChangeScore(killReward);
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}