using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class list_loop : MonoBehaviour
{

    //    public int i;
    public string[] Animal;

    // Use this for initialization
    void Start()
    {
        //	while(i < Animal.Length)
        //        {
        //            i++;
        //       }
        //    }
        foreach (string item in Animal)
        {
            if (item == "Cat")
            {
                print(item);
            }
        }
    }
}