using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCStats : MonoBehaviour {

    public string npcName;
    [Header("Dialogs")]
    public string dialogNeed;
    public string dialogSell;
    public string dialogGive;
    [Header("Quest status")]
    public bool needItem;

    [Header("Inventory")]
    public GameObject[] inventory;
}
