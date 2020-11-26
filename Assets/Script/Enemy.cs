using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private HealthEnemy _enemyHealth;
    private void Awake()
    {
        _enemyHealth = GetComponent<HealthEnemy>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            _enemyHealth.TakeDamage(1f);
        }
    }

    public void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}
