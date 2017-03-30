using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemInteraction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionStay(Collision collision) {
        if (collision.gameObject.tag == "Item" && Input.GetButtonDown("Interact")) {
            gameObject.GetComponent<PlayerStats>().TakeItem(collision.gameObject);
            collision.gameObject.transform.parent = gameObject.transform;
            collision.gameObject.SetActive(false);
        }
    }
}
