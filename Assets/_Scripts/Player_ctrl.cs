using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ctrl : MonoBehaviour {
	public float speed_ctrl;
	public float jump_height;
	private bool can_jump;
	public float jump_delay;
	// Use this for initialization
	void Start () {
		jump_height = 200f;
		speed_ctrl = 10f;
		can_jump = true;
		jump_delay = 0.2f;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate (speed_ctrl*Input.GetAxis ("Horizontal") * Time.deltaTime,0f,speed_ctrl*Time.deltaTime* Input.GetAxis ("Vertical"));
		if (Input.GetKeyDown (KeyCode.Space)&&can_jump) 
		{
			transform.Translate (0f,jump_height*Time.deltaTime,0f);
			//fake jump
			can_jump=false;
			StartCoroutine (JumpDelay ());
		}
	}
	IEnumerator JumpDelay() {
		//can_jump = false;
		yield return new WaitForSeconds(jump_delay);
		can_jump = true;
		yield break;
	}

}
