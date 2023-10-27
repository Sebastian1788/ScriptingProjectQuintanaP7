using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Variables : MonoBehaviour
{
    int myInt = 5;

    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    void Update()
    {


    }

    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}

