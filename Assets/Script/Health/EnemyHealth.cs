using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    private Quaternion rotate;
    [SerializeField] private GameObject follow;
    private Vector3 testLocation;

    void Awake()
    {
        OnWakeUp();
        rotate = transform.rotation;
        follow = GameObject.FindGameObjectWithTag("Enemy");
    }

    void Update()
    {
        transform.rotation = rotate;
        testLocation = follow.transform.position;
        this.gameObject.transform.position = new Vector3(testLocation.x, transform.position.y, testLocation.z + 1.5f);
    }
}


