using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float StartHealth;
    public Image Healthbar;
    public float health;

    public void OnWakeUp()
    {
        health = StartHealth;
    }

    public void test()
    {
        Healthbar.fillAmount = health / StartHealth;
    }
}
