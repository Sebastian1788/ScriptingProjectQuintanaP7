using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] strings = new string[3];

        strings[0] = "first string";
        strings[1] = "second string";
        strings[3] = "third string";

        foreach (string item in strings)
        {
            print(item);

        }

        // Update is called once per frame
        void Update()


        }
    }
}
