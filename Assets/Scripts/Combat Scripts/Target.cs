using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour, IDamageable
{
    [SerializeField] private float health = 100f;
    [SerializeField] ParticleSystem collectParticle = null;

    public void Update()
    {
        
    }

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
