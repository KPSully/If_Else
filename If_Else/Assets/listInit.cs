using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listInit : MonoBehaviour
{
    public class strings
    {
        public List<string> stringsList;

        //       public List<string> stringsList;

        void Start()
        {
            for (int i = 0; i < stringsList.Count; i++)
            {
                print(stringsList[i]);
            }
        }
    }
}