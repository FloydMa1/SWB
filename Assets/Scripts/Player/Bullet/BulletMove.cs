using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

    Rigidbody rigid;
    [SerializeField] private float speed = 200;
    public Vector3 direction;
    public GameObject hitParticle;

    [SerializeField] int destroyTime = 5;

	void Start () {
        rigid = GetComponent<Rigidbody>();
        transform.Rotate(90, 0, 0);
        StartCoroutine(DestroyLaser());
	}
	

	void Update () {
        transform.position += -direction * speed * Time.deltaTime;
    }

    IEnumerator DestroyLaser()
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(gameObject);
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Instantiate(hitParticle, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }

    }
}
