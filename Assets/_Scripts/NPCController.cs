using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCController : MonoBehaviour {

    public GameObject canvasDialog;
    public Text speech;

    private NPCStats stats;
        
	// Use this for initialization
	void Start () {
        canvasDialog.SetActive(false);
        stats = GetComponent<NPCStats>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Player") {
            if (stats.needItem) {
                speech.text = stats.dialogNeed;
                canvasDialog.SetActive(true);
            }
        }
    }
}
