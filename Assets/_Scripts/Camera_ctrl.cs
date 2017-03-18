using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_ctrl : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
		//offset.z = 0;
	}

	// Update is called once per frame
	void LateUpdate () {
		Vector3 player_pos = player.transform.position;
		player_pos.y = 0f;
		transform.position = player_pos + offset;

	}
}
