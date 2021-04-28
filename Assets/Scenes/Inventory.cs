using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // the inventory of every item. always set to false unless the item is clicked on, which then makes it become true
    private static Inventory _main;

    public static Inventory main
    {
        get { return _main; }
    }

    public bool hasKey = false;
    public bool hasHat = false;
    public bool hasBooks = false;
    public bool hasMoney = false;
    public bool hasPhone1 = false;
    public bool hasBall = false;
    public bool hasPhone2 = false;
    public bool hasLaptop = false;


    private void Start()
    {
        if (_main == null)
        {
            _main = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
