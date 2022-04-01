using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour, IDamageable
{
    private float health = 100f;
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Debug.Log("Enemy killed!");
            Destroy(gameObject);
        }
    }
}
