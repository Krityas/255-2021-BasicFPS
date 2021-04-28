using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerInventoryGUI : MonoBehaviour
{
    // inventory gui system. when something is picked up, it'll appear on screen on the list
    public Transform imgKey;
    public Transform imgHat;
    public Transform imgBooks;
    public Transform imgPhone1;
    public Transform imgPhone2;
    public Transform imgLaptop;
    public Transform imgBall;
    public Transform imgMoney;


   

    // every text image of each item
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
