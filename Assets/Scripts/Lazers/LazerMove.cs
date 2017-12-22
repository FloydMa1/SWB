using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerMove : MonoBehaviour {

    private float movespeed = 500;
    private Vector3 moveDirection;

    public Transform Target;
    new Rigidbody rigidbody;
    private Vector3 temp;

    private void Start()
    {
        Target = GameObject.Find("Player").transform;
        temp = Target.position;
        moveDirection = Target.transform.position - transform.position;
        //print(moveDirection.normalized);
        rigidbody = gameObject.GetComponent<Rigidbody>();
        transform.LookAt(Target);
        transform.Rotate(90, 0, 0, Space.Self);

    }

    void Update () {
        float step = movespeed * Time.deltaTime;
        rigidbody.MovePosition(transform.position + moveDirection.normalized * step);
        Destroy(gameObject, 4f);
	}

}
