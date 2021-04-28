using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooksPickup : MonoBehaviour
{
    //pickup script for the book game object
    public void BooksInteract()
    {


        Inventory.main.hasBooks = true;


        Destroy(gameObject);
    }
}
