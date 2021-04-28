using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPickup : MonoBehaviour
{

    // pickup script for the ball game object
    public void BallInteract()
    {

      
       Inventory.main.hasBall = true;


        Destroy(gameObject);
    }
}
