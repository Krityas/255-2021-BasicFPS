using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour
{
    //pickup script for the key game object
    public void WallDestroyed()
    {


        Inventory.main.hasKey = true;


        Destroy(gameObject);
    }
}
