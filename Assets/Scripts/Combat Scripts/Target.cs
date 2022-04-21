using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour, IDamageable
{
    public float health = 100f;
    [SerializeField] ParticleSystem collectParticle = null;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Debug.Log("Enemy killed!");
            Destroy(gameObject);
            Collect();
        }
    }

    public void Collect()
    {
        collectParticle.Play();
    }
}
