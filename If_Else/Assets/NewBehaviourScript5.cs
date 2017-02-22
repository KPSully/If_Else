using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewBehaviourScript5 : MonoBehaviour {

    public string myWeapon;
    public List<string> myStringList;
    public string[] myStringArray;

	// Use this for initialization, Lists are more advanced. Lists are an upgrade to arrays, as lists can be modified.
	void Start () {
        myStringList.Add("Sword");
        myStringList.Remove("Gun");
        myStringList.Add("Bow");
        myStringList.RemoveAt(1);
	}

    public void MyMouseClick()
    {
        myStringList.Add("SwordLv2");
    }
}