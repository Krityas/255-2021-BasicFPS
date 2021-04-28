using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatPickup : MonoBehaviour
{
    //pickup script for the hat game object
     public void HatInteract()
    {


        Inventory.main.hasHat = true;


        Destroy(gameObject);
    }
}
