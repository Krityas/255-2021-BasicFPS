using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    private Camera cam;


    private float doorAngle = 0;

    void Start()
    {
        cam = Camera.main;
    }

    public void PlayerInteract(Vector3 position)
    {
        if (animIsPlaying == true) return;

        if (inventory.main.hasKey == false) return;

        Vector3 disToPlayer = position - transform.position;
        disToPlayer = disToPlayer.normalized;

        bool playerOnOtherSide = (Vector3.Dot(disToPlayer, transform.forward) > 0f);

        isClosed = !isClosed;

        if (!isClosed)
        {
            doorAngle = 90;
            if (playerOnOtherSide) doorAngle = -90;
        }
    }    
}

        


    
    

