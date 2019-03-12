using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	public float speed;
	void start(){
		GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}
}
