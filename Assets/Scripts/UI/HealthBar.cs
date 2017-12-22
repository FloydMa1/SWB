using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public GameObject player;
    float barSpeed;
    public Image bar;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        barSpeed = player.GetComponent<PlayerHealth>().ReturnHealth();
        bar.fillAmount = barSpeed / 100;
    }
}
