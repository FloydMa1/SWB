using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    public Transform LoadingBar;
    public Transform TextIndicator;
    [SerializeField] private float currentAmount;
    [SerializeField] private float speed;
	
	// Update is called once per frame
	void Update () {
		if(currentAmount > 0)
        {
            currentAmount -= speed * Time.deltaTime;
            //TextIndicator.GetComponent<Text>().text = ((int)currentAmoutn).ToString()+"%";

        }
        else
        {
            
        }
        LoadingBar.GetComponent<Image>().fillAmount = currentAmount / 100;
	}
}
