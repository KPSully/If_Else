using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public bool fun;
    public bool bankrupt = true;
    public bool untrue = true;
    public bool locked = false;
    public bool empty = true;

	// Use this for initialization
	void Start () {
		if (fun == true)
        {
            print("Yay");
        }
        else
        {
            print("Boo");
        }
        if (bankrupt == true)
        {
            print("Oh, snap!");
        }
        else
        {
            print("Phew");
        }
        if (untrue == true)
        {
            print("False");
        }
        else
        {
            print("True");
        }
        if (locked == false)
        {
            print("You open the not locked thing");
        }
        else
        {
            print("You don't open the locked thing");
        }
        if (empty == false)
        {
            print("You are upset");
        }
        else
        {
            print("You are happy");
        }
	}

	// Update is called once per frame
	void Update () {
		
	}
}
