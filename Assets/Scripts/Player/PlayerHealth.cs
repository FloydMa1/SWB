using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float health = 100f;
    private bool shieldOn = false;


    private bool godMode = false;

    [SerializeField] private GameObject lazer;
    LazerCollision col;

     void Start()
    {
        col = lazer.GetComponent<LazerCollision>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.G)&& Input.GetKey(KeyCode.O)&& Input.GetKeyDown(KeyCode.D) && godMode == false)
        {
            godMode = true;
            Debug.Log("Cheat Activated!");
        }
        else if (Input.GetKey(KeyCode.G) && Input.GetKey(KeyCode.O) && Input.GetKeyDown(KeyCode.D) && godMode == true)
        {
        
            godMode = false;
            Debug.Log("Cheat Deactivated!");
        }

        if (godMode)
        {
            health = 100f;
        }
    }

    public void Damage(float dam)
    {
        health -= dam;
    }

    public float ReturnHealth()
    {
        return health;
    }

     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            health = 0;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }

}
