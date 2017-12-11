using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    GameObject lazer;
    float barSpeed;
    public Image bar;

    // Use this for initialization
    void Start()
    {
        lazer = GameObject.FindWithTag("Lazer");
    }

    // Update is called once per frame
    void Update()
    {
        barSpeed = lazer.GetComponent<PlayerHealth>().ReturnHealth();
        bar.fillAmount = barSpeed / 100;
    }
}
