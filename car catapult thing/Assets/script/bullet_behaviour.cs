using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class bullet_behaviour : MonoBehaviour {
	private Rigidbody my_Rigidbody;
	// Use this for initialization
	void Start () {
		my_Rigidbody = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		//my_Rigidbody.AddForce(Vector3.forward);
		my_Rigidbody.transform.Translate(Vector3.forward);
	}
	private void OnCollisionEnter (Collision collidedobject) {
		if (collidedobject.gameObject.tag == "Enemy") {
			print (collidedobject.gameObject.name);	
			print (collidedobject.transform.position);
			Destroy (collidedobject.gameObject);
		}
	}
}
