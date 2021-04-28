using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopPickup : MonoBehaviour
{
    //pickup script for the laptop game object
    public void LaptopInteract()
    {


        Inventory.main.hasLaptop = true;


        Destroy(gameObject);
    }
}
