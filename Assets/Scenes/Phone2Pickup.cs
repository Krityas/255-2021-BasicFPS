using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone2Pickup : MonoBehaviour
{
    //pickup script for the phone2 game object
    public void Phone2Interact()
    {


        Inventory.main.hasPhone2 = true;


        Destroy(gameObject);
    }
}
