using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInventoryGUI : MonoBehaviour
{
    public Transform imgKey;
    public Transform imgHat;
    public Transform imgBooks;
    public Transform imgPhone1;
    public Transform imgPhone2;
    public Transform imgLaptop;
    public Transform imgBall;
    public Transform imgMoney;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        imgKey.gameObject.SetActive(Inventory.main.hasKey);
        imgHat.gameObject.SetActive(Inventory.main.hasHat);
        imgBooks.gameObject.SetActive(Inventory.main.hasBooks);
        imgPhone1.gameObject.SetActive(Inventory.main.hasPhone1);
        imgPhone2.gameObject.SetActive(Inventory.main.hasPhone2);
        imgLaptop.gameObject.SetActive(Inventory.main.hasLaptop);
        imgBall.gameObject.SetActive(Inventory.main.hasBall);
        imgMoney.gameObject.SetActive(Inventory.main.hasMoney);
    }
}
