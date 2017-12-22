using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroy : MonoBehaviour {

	void Update () {
        Destroy(this.gameObject, 2);
	}
}
