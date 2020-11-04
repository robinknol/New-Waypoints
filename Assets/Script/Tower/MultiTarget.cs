using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTarget : Tower
{
    private Enemy[] _enemies;

    protected override bool CanAttack()
    {
        _enemies = _rangeChecker.GetAllEnemiesInRange();
        if (_enemies != null)
        {
            if (_enemies.Length >= 1)
            {
                return true;
            }
        }
        return false;
    }

    protected override void Attack()
    {
        foreach (var enemy in _enemies)
        {
            print("Attack this enemy: " + enemy.name);
        }
    }
}
