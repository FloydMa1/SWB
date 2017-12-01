using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour {

    public GameObject objective1;
    public GameObject objective2;

    public bool objCheck1;
    public bool objCheck2;

    // Use this for initialization
    void Start () {
        objCheck1 = false;
        objCheck2 = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject == objective1)
        {
            objCheck1 = true;
            Debug.Log("Objective 1 completed!");
        }
        else if(col.gameObject == objective2 && objCheck1 == true)
        {
            objCheck2 = true;
            Debug.Log("Objective 2 completed!");
        }
    }
}
