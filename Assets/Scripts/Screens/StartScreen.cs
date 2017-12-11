using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour {

    [HideInInspector]
    public bool startGame;

    public GameObject[] UI; 

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 0F;
        startGame = false;
        foreach (GameObject ui in UI)
        {
            ui.SetActive(false);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        foreach (GameObject ui in UI)
        {
            ui.SetActive(true);
        }
        gameObject.SetActive(false);
    }
}
