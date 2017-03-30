using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_player_ctrl : MonoBehaviour {
	public Animator ami;
	public float jump_height;
	public CharacterController ctrll;
	private bool ami_flag;
	//public float moveDirection;
	// Use this for initialization
	void Start () {
		ami = GetComponent<Animator> ();
		ctrll = GetComponent<CharacterController> ();
		ami_flag = true;
		jump_height = 200f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("k")) {
			ami.Play ("WK_heavy_infantry_08_attack_B", -1, 0.2f);
		}
		//if (Input.GetKeyDown ("w") || Input.GetKeyDown ("a") || Input.GetKeyDown ("s") || Input.GetKeyDown ("d")&&ami_flag) {
		//	ami.Play ("WK_heavy_infantry_04_charge", -1, 0f);
			
		//}
		if (Input.GetKeyDown("w")&&ami_flag){ami_flag=false;ami.Play ("WK_heavy_infantry_04_charge", -1, 0f);ami_flag=true;}
		if (Input.GetKeyDown("a")&&ami_flag){ami_flag=false;ami.Play ("WK_heavy_infantry_04_charge", -1, 0f);ami_flag=true;}

		if (Input.GetKeyDown("s")&&ami_flag){ami_flag=false;ami.Play ("WK_heavy_infantry_04_charge", -1, 0f);ami_flag=true;}
		if (Input.GetKeyDown("d")&&ami_flag){ami_flag=false;ami.Play ("WK_heavy_infantry_04_charge", -1, 0f);ami_flag=true;}

		//if (ctrll.isGrounded) {
		//	moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		//	moveDirection = transform.TransformDirection(moveDirection);
		//	moveDirection = moveDirection* 10f;
		Vector3 NextDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		if (NextDir != Vector3.zero)
			transform.rotation = Quaternion.LookRotation (NextDir);
		ctrll.Move (NextDir / 4);



		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			transform.Translate (0f,jump_height*Time.deltaTime,0f);
			//fake jump
			//can_jump=false;
			//StartCoroutine (JumpDelay ());
		}
	}
}
