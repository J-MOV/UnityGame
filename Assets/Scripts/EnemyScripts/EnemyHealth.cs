﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    public EnemySO enemyStats;
    public int enemyHealth;

    public Slider healthSlider;

    private void Awake()
    {
        healthSlider = GameObject.FindGameObjectWithTag("EnemyHealthBar").GetComponent<Slider>();
        if (!enemyStats)
        {
            Debug.LogWarning("No Enemy Stats were found!");
        }
        else 
        { 
            healthSlider.maxValue = enemyStats.enemyHealth;
            healthSlider.value = healthSlider.maxValue;

            enemyHealth = enemyStats.enemyHealth;

            Debug.Log("Added stats to enemy");
        }

        
    }
    
    public void TakeDamage(int damage)
    {
        enemyHealth -= damage;
        healthSlider.value = enemyHealth;
        if (enemyHealth <= 0)
        {
            FindObjectOfType<DungeonManager>().OnEnemyDeath();
            Destroy(gameObject);
        }
    }

}
