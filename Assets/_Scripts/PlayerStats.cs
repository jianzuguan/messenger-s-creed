using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public List<GameObject> inventory = new List<GameObject>();

    public bool TakeItem(GameObject item) {
        inventory.Add(item);
        // TODO: check if the item is succesfully added
        return true;
    }

    public bool DropItem(GameObject item) {
        return inventory.Remove(item);
    }
}
