using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add : MonoBehaviour
{
    public string theButton;
    public listInit.strings listString;

    public void AddToList()
    {
        listString.stringsList.Add(theButton);
    }
//    public void Add{
//        listStrings add theButton
//    }
}