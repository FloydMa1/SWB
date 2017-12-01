using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerMove : MonoBehaviour {

    private float movespeed = 70;
    private Vector3 moveDirection;

    public Transform Target;
    private Vector3 temp;

    private void Start()
    {
        Target = GameObject.Find("SpaceShitParent").GetComponent<Transform>();
        temp = Target.position;
        moveDirection = Target.transform.position - transform.position;
        //print(moveDirection.normalized);
    }

    void Update () {
        float step = movespeed * Time.deltaTime;
        transform.Translate(moveDirection.normalized * step);
	}

}
