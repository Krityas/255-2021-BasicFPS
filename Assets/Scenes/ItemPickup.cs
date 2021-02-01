using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{


    public void PlayerInteract()
    {

        Inventory.main.hasKey = true;
        Inventory.main.hasBooks = true;
        Inventory.main.hasLaptop = true;
        Inventory.main.hasMoney = true;
        Inventory.main.hasPhone1 = true;
        Inventory.main.hasPhone2 = true;
        Inventory.main.hasHat = true;
        Inventory.main.hasBall = true;


        Destroy(gameObject);
    }
}
