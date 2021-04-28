using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{

    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        // did the user click on this game tick?
        if (cam != null && Input.GetButtonDown("Fire1"))
        {



            // shoot a ray into the scene
            Ray ray = new Ray(cam.transform.position, cam.transform.forward);
            RaycastHit hit;

            //draw ray:
            Debug.DrawRay(ray.origin, ray.direction, Color.red, .5f);

            if (Physics.Raycast(ray, out hit))
            {
                // raycast hit a collider in the scene!

                //DoorController door = hit.transform.GetComponent<DoorController>();
                //if (door != null) door.PlayerInteract(transform.parent.position);
                HatPickup hatpickup = hit.transform.GetComponent<HatPickup>();
                if (hatpickup != null) hatpickup.HatInteract();

                BallPickup ballpickup = hit.transform.GetComponent<BallPickup>();
                if (ballpickup != null) ballpickup.BallInteract();

                KeyPickup keypickup = hit.transform.GetComponent<KeyPickup>();
                if (keypickup != null) keypickup.KeyInteract();

                MoneyPickup moneypickup = hit.transform.GetComponent<MoneyPickup>();
                if (moneypickup != null) moneypickup.MoneyInteract();

                Phone1Pickup phone1pickup = hit.transform.GetComponent<Phone1Pickup>();
                if (phone1pickup != null) phone1pickup.Phone1Interact();

                Phone2Pickup phone2pickup = hit.transform.GetComponent<Phone2Pickup>();
                if (phone2pickup != null) phone2pickup.Phone2Interact();

                LaptopPickup laptoppickup = hit.transform.GetComponent<LaptopPickup>();
                if (laptoppickup != null) laptoppickup.LaptopInteract();

                BooksPickup bookspickup = hit.transform.GetComponent<BooksPickup>();
                if (bookspickup != null) bookspickup.BooksInteract();
            }
        }
    }
}