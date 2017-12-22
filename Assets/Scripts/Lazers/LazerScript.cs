using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerScript : MonoBehaviour {

    private float timer;
    private float range = 100f;
    private float timeBetweenLazers = 1.2f;
    public GameObject lazer;

    private void Awake()
    {

    }

    void Update () {
        timer += Time.deltaTime;

        if (timer >= timeBetweenLazers)
        {
            Shoot();
        }
        Debug.DrawRay(transform.position
            , transform.forward, Color.blue);

    }

    private void Shoot()
    {  
        timer = 0f;
        Instantiate(lazer, transform.position, Quaternion.identity);
    }

}
