using UnityEngine;
using System.Collections;

public class NewBehaviourScript2 : MonoBehaviour {

    int i = 0;
    public string[] colors;

	// Use this for initialization
	void Start () {
        while(i < colors.Length)
        {
            print(colors[i]);
            (i)++;
        }
        print("done");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
