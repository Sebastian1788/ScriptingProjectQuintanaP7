using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeTimer : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotlimitTemperature = 70.0f;
    float coldlimitTemperature = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            

        coffeeTemperature -= Time.deltaTime * 5f;
        
    }


    void Temperature()
    {

        if (coffeeTemperature > hotlimitTemperature)
        {

            print("Coffee is too hot");
        }
        else if (coffeeTemperature > coldlimitTemperature)
        {

        }
}
