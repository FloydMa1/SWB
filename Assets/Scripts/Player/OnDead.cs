using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDead : MonoBehaviour {

    public bool isDead;
    public GameObject deadblock;
    public GameObject deathParticle;
    public GameObject enemy;
    public GameObject[] UI;

    // Use this for initialization
    void Start () {
        isDead = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.Find("Player").GetComponent<PlayerHealth>().health <= 0)
        {
            isDead = true;
            Instantiate(deadblock, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
            

            foreach (GameObject ui in UI)
            {
                ui.SetActive(false);
            }

            StartCoroutine(WaitTillDestroy());
            
        }
	}

    IEnumerator WaitTillDestroy()
    {
        Instantiate(deathParticle, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0f);

        Destroy(gameObject);
        enemy.SetActive(false);
        //Destroy(deathParticle.gameObject, 3);
        
    }
}
