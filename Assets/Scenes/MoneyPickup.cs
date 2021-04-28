using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPickup : MonoBehaviour
{
    // pickup script for the money game object
    public void MoneyInteract()
    {


        Inventory.main.hasMoney = true;


        Destroy(gameObject);
    }
}
