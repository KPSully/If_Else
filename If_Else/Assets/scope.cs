using UnityEngine;
using System.Collections;

public class scope : MonoBehaviour {

    public string userName = "Bob";

	// Use this for initialization
    void Awake ()
    {
        string myName = "Joe";
        if(myName == "Joe")
        {
            string otherName = "Helen";
            print(myName + "ate" + otherName);
        }
        print(myName);
        print(userName);
    }
	void Start () {
        string myName = "Jeff";
        print(userName);
        print(myName);
	}
}
