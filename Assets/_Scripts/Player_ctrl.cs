using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ctrl : MonoBehaviour {
	public float speed_ctrl;
	//private Vector3 pos_tmp;
	// Use this for initialization
	void Start () {
		
		speed_ctrl = 10f;
		
	}
	
	// Update is called once per frame
	void Update () {
		//Input.GetAxis ("Vertical");
		transform.Translate (speed_ctrl*Input.GetAxis ("Horizontal") * Time.deltaTime,0f,speed_ctrl*Time.deltaTime* Input.GetAxis ("Vertical"));
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Vector3 pos_tmp = transform.TransformDirection(Vector3.up);
			Rigidbody rb = GetComponent<Rigidbody>();
			rb.AddForce (pos_tmp * 300f);
		}
	}
}
