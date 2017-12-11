
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject playerBullet;
    public GameObject[] GunBarrels;
    private bool canShoot;

	void Start () {
		
	}
	
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Shoot();
        }
	}

    void Shoot()
    {
        
    }
}
