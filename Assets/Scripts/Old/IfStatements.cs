using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 80f;
    float hotLimitTemperature = 70f;
    float coldLimitTemperature = 40f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }
        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        if(coffeeTemperature > hotLimitTemperature)
        {
            print("Too hot");
        }
        else if(coffeeTemperature < coldLimitTemperature)
        {
            print("Too cold");
        }
        else
        {
            print("Right temperature");
        }
    }
}
