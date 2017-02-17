using UnityEngine;
using System.Collections;

public class NewBehaviourScript3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame, with KeyCode try to isolate them all into ONE update.
	void Update() {
        if (Input.GetKey(KeyCode.A))
        {
            print("A");
        }
        else
        {
            print("No input");
        }
    }
}
