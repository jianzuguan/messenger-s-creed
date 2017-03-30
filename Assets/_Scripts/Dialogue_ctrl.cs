using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue_ctrl : MonoBehaviour {
	//public GameObject dialogue_window;
	public Text actual_text;
	private GameObject panel;
	// Use this for initialization
	void Start () {
		panel=GameObject.FindGameObjectWithTag ("dialogue_panel");
		//panel.SetActive (false);
		actual_text = panel.GetComponentInChildren<Text> ();
		//EndDialogue ();
		
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetKey ("g"))
		//	ThrowDialogue();
		//if (Input.GetKey ("h"))
		//	EndDialogue ();
	}
	public void ThrowDialogue(string npcName="Rumble",string content="This is an NPC")
	{
		panel.SetActive (true);
		actual_text.text=content;

		//actual_text.text=
	}
	public void EndDialogue()
	{
		panel.SetActive (false);
	}
















}
