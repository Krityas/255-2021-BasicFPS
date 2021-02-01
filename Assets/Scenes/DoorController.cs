using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    public Transform doorArt;

    private Camera cam;

    private float doorAngle = 0;

    public float animLength = 0.5f;
    private float animTimer = 0;
    private bool animIsPlaying = false;

    private bool isClosed = true;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (animIsPlaying)
        {
            animTimer += Time.deltaTime;

            float percent = animTimer / animLength;

            if (percent < 0) percent = 0;
            if (percent > 1) percent = 1;

            doorAngle = percent * 90;
            doorArt.rotation = Quaternion.Euler(0, doorAngle, 0);
        }
    }


    public void PlayerInteract(Vector3 position)
    {
        
        
        if (Inventory.main.hasKey == false) return;

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







