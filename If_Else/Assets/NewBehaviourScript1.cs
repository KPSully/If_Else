using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {

    public string Animal;
    // Use this for initialization
    void Start()
    {
        switch (Animal)
        {
            case ("Dog"):
                print("Dog");
                break;
            case ("Cat"):
                print("Cat");
                    break;
            case ("Frog"):
                print("Frogs are the superior animal");
                break;

        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
