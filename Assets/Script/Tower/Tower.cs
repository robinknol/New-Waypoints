using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    protected EnemyRange _rangeChecker;
    public float damage;
    private void Awake()
    {
        _rangeChecker = GetComponent<EnemyRange>();
    }

    private void Update()
    {
        if (!CanAttack()) return;

        Attack();
    }

    protected virtual bool CanAttack()
    {
        return false;
    }

    protected virtual void Attack()
    {
        Debug.Log(message: "Attack");
    }
}
