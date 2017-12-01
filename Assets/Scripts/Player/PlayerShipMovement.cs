using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipMovement : MonoBehaviour {

    [Range(10f,30f)]
    [SerializeField] float movementSpeed;
    [SerializeField] float turnSpeed;
    [SerializeField] float maxSpeed;
    [SerializeField] float minSpeed;

    Transform myT;

	// Use this for initialization
	void Start () {
        myT = transform;
	}
	
	// Update is called once per frame
	void Update () {
        ChangeMovementSpeed();
        Turn();
        Thrust();
    }

    void ChangeMovementSpeed()
    {
        if (Input.GetAxis("MovementSpeed") > 0 && movementSpeed <= maxSpeed)
        {
            movementSpeed += 10 * Time.deltaTime;
        }
        else if(Input.GetAxis("MovementSpeed") < 0 && movementSpeed >= minSpeed)
        {
            movementSpeed -= 10 * Time.deltaTime;
        }
    }

    void Turn()
    {
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Pitch");
        float roll = turnSpeed * Time.deltaTime * Input.GetAxis("Roll");

        myT.Rotate(pitch, yaw, -roll);
    }

    void Thrust()
    {
         myT.position += myT.forward * movementSpeed * Time.deltaTime;
    }
}
