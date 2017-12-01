using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    private float health = 100;
    private bool shieldOn = false;

    [SerializeField]private GameObject lazer;
    LazerCollision col;

     void Start()
    {
        col = lazer.GetComponent<LazerCollision>();
    }

     void Update()
    {
        if (col.isHit == true)
        {
            Debug.Log("moan");
        }
    }

}
