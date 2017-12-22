using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerCollision : MonoBehaviour {

    public GameObject particleHit;
    public bool isHit;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var a = Instantiate(particleHit, transform.position, Quaternion.identity);
            Destroy(a, 1.5f);
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            collision.gameObject.GetComponent<PlayerHealth>().Damage(5);
        }
    }

}
