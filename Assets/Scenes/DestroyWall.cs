using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    //pickup script for the key game object
    public void DestroyedWall()
    {


        Inventory.main.hasPhone2 = true;


        Destroy(gameObject);
    }
}
