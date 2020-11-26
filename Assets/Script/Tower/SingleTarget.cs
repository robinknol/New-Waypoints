using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTarget : Tower
{
    private Enemy _target;
    public GameObject TargetHealth;
    protected override bool CanAttack()
    {
        _target = _rangeChecker.GetFirstEnemyInRange();
        return _target != null;
    }

    protected override void Attack()
    {
        enemyHealth.TakeDamage();
        Debug.Log(_target);
    }
}
