using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedBar : MonoBehaviour {

    public GameObject player;
    float barSpeed;
    public Image bar;

	// Use this for initialization
	void Start () {
        //player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        barSpeed = player.GetComponent<PlayerShipMovement>().ReturnSpeed();
        bar.fillAmount = barSpeed / 60;
    }
}
