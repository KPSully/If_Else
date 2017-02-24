using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Addtoinv : MonoBehaviour {

    public NewBehaviourScript6.lists myInv;
    public string myWeapon;  

    public void AddToList()
    {
        myInv.myWeaponList.Add(myWeapon);
    }
        
}
