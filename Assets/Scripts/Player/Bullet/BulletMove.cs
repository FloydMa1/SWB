using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

    Rigidbody rigid;
    private float speed;

	void Start () {
        rigid = GetComponent<Rigidbody>();

        speed = 10f;
	}
	

	void Update () {
        rigid.velocity = -transform.forward * speed;
	}
}
