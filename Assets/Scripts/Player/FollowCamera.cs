using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    [SerializeField] Transform target;
    [SerializeField] Vector3 defaultDistance = new Vector3(0f, 2f, -10f);
    [SerializeField] float distanceDamp = 10f;
    [SerializeField] float rotationalDamp = 10f;

    public Transform deadblock;

    Transform myT;

	// Use this for initialization
	void Start () {
        myT = transform;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        if (GameObject.Find("SpaceShitParent"))
        {
            Vector3 toPos = target.position + (target.rotation * defaultDistance);
            Vector3 curPos = Vector3.Lerp(myT.position, toPos, distanceDamp * Time.deltaTime);
            myT.position = curPos;

            Quaternion toRot = Quaternion.LookRotation(target.position - myT.position, target.up);
            Quaternion curRot = Quaternion.Slerp(myT.rotation, toRot, rotationalDamp * Time.deltaTime);
            myT.rotation = curRot;
        }
        else if(GameObject.Find("DeadBlock(Clone)"))
        {
            transform.LookAt(deadblock);
            transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
        }
    }
}
