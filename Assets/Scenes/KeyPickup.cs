using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    //pickup script for the key game object
    public void KeyInteract()
    {


        Inventory.main.hasKey = true;


        Destroy(gameObject);
    }
}
