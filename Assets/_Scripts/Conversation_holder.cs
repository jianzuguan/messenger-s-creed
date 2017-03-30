using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversation_holder : MonoBehaviour {
	public int npcState;
	public int dialogueIndex;
	public string[] dialogues;
	//public string[][] test_2d;
	public string[,] test;
	public string npcName;
	//public 
	//public Button continuebutton;
	private GameObject panel;
	private Dialogue_ctrl sc; 


	// Use this for initialization
	void Start () {
		panel=GameObject.FindGameObjectWithTag ("dialogue_panel");
		sc = panel.GetComponent<Dialogue_ctrl> ();
		Button btn2 = panel.GetComponentInChildren<Button> ();
		Button btn = btn2.GetComponent<Button> ();
		btn.onClick.AddListener (BtnClicked);
		npcName="Rumble";
		test= new string[4,4];
		dialogueIndex = 0;
		npcState = 0;

		test [0, 0]="oh my god";
		test [0, 1] = "you look great today";
		test [0, 2]= "wanna some cookies?";
		test [0, 3] = "i have a mission for you";


		test[1,0]="dont piss me off, go away";
		test[1,1]="i told ya!";

		test [2, 0] = "welcome back young man";
		test [2, 1]="nice weather, hum?";

		
	}
	void BtnClicked(){
	//	sc.ThrowDialogue("npc_name",dialogues[index]);

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp ("c")) {
			npcState++;
			dialogueIndex = 0;
		}
		if (Input.GetKeyUp ("z"))
		//if (Input.GetKeyUp ("z") && dialogueIndex < test.GetLength (2) && npcState < test.GetLength (1))
 {			//sc.ThrowDialogue();
			sc.ThrowDialogue (npcName, test [npcState, dialogueIndex]);
			dialogueIndex++;
		}
		if (Input.GetKey ("x"))
			//sc.EndDialogue ();
			sc.EndDialogue ();
		//Dialogue_ctrl.t

	}

	public string GetCov(int index)
	{
		return dialogues [index];
	}
}
