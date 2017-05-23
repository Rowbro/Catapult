using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class gun : MonoBehaviour {
	public GameObject bullet_Prefabs;
	private bool Mouse_pressed; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//check for inputs
		if (Input.GetKey (KeyCode.Mouse0)) {
			print ("Mouse Clicked");
			Mouse_pressed = true;
		} else {
			Mouse_pressed = false;
		}

	}
	void FixedUpdate(){
		//Apply physics
		if (Mouse_pressed == true) {
			Instantiate (bullet_Prefabs, gameObject.transform.position, gameObject.transform.rotation);
		}
	
	}
	private void OnCollisionEnter (Collision collidedobject) {
		if (collidedobject.gameObject.tag == "WinCon") {
			print ("Win");
		}
		
}
}
    
