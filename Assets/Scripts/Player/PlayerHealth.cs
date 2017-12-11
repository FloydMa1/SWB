using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float health = 100f;
    private bool shieldOn = false;

    [SerializeField] private GameObject lazer;
    LazerCollision col;

     void Start()
    {
        col = lazer.GetComponent<LazerCollision>();
    }

    public void Damage(float dam)
    {
        health -= dam;
        //print("moan");
    }

    public float ReturnHealth()
    {
        return health;
    }

}
