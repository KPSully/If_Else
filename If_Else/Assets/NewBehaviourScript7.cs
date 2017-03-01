using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewBehaviourScript7 : MonoBehaviour {

    public List<GameObject> powerUpList;
    public List<GameObject> cubeList;
    public List<GameObject> sphereList;
    public List<GameObject> capsuleList;

	// Use this for initialization
	void Start () {
        foreach (GameObject item in powerUpList)
        {
            switch(item.name)
            {
                case "Cube":
                    cubeList.Add(item);
                    break;
                case "Sphere":
                    sphereList.Add(item);
                    break;
                case "Capsule":
                    capsuleList.Add(item);
                    break;

            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
