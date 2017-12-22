
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject playerBullet;
    public GameObject[] GunBarrels;
    private bool shootingAble;
    private bool canShoot;

	void Start () {
        shootingAble = true;
	}
	
	void Update () {
        if (Input.GetMouseButtonDown(0) && shootingAble && GameObject.Find("Canvas").GetComponent<ButtonController>().startGame == true)
        {
            Shoot();
            StartCoroutine(ShootDelay());
                AudioSource audio = GetComponent<AudioSource>();
                audio.Play();
        }
    }

    void Shoot()
    {
        shootingAble = false;
        RaycastHit shootHit;
        var obj = Instantiate(playerBullet, transform.position, Quaternion.identity).GetComponent<BulletMove>();

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out shootHit))
        {
            var direction = transform.position - shootHit.point;
            obj.direction = direction.normalized;
            obj.transform.rotation = Quaternion.LookRotation(transform.forward);
        }
        else
        {
            obj.direction = -transform.forward - shootHit.point;
            obj.transform.rotation = Quaternion.LookRotation(transform.forward);
        }
    }

    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(1);
        shootingAble = true;
    }
}
