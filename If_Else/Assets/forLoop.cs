using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class forLoop : MonoBehaviour {

    public List<string> car;

	// Use this for initialization
	void Start () {
	for (int i = 0; i < car.Count; i++)
        {
            print(car[i]);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
