using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : Health
{
    public Text Number;

    [SerializeField] ParticleSystem LEST;

    private void Start()
    {
        LEST.Stop();
        OnWakeUp();
        Number.text = health.ToString();
    }

    public void TakeDamage()
    {
        health -= 10;

        Number.text = health.ToString();
        test();

        StartCoroutine(PlayExplosion());
    }

    IEnumerator PlayExplosion()
    {
        LEST.Play();
        yield return new WaitForSecondsRealtime(2);
        LEST.Stop();
    }
}
