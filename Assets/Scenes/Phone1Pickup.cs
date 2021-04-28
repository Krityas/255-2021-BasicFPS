using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone1Pickup : MonoBehaviour
{
    //pickup script for the phone1 game object
    public void Phone1Interact()
    {


        Inventory.main.hasPhone1 = true;


        Destroy(gameObject);
    }
}
