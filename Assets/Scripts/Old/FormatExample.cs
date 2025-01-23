using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormatExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("I am {0}, I am {1} years old.", "IronMan", 55);
        Debug.Log($"I am {"Irom Man"}, Iam {55} years old");
        Debug.LogFormat("I am {0}, I am {1} years old.", "Superman", 100);
        Debug.LogFormat("I am {0}, You are not {0}.", "Thor");

        Debug.Log("--------------------------------------------------");

        float value1 = 123;
        Debug.Log(value1.ToString("00000"));
        Debug.Log($"value1 is {value1:00000}");

        Debug.Log(value1.ToString("00000"));
        Debug.Log($"value1 is {value1:#####}");

        float value2 = 1.23f;
        Debug.Log(value1.ToString("00000"));
        Debug.Log($"value1 is {value2:0.00}");

        float value3 = 1234567890;
        Debug.Log(value1.ToString("00000"));
        Debug.Log($"value1 is {value3:#,#}");

        // float value1 = 123;
        // Debug.Log(value1.ToString("00000"));
        // Debug.Log(string.Format("value1 is {0:00000}", value1));

        // Debug.Log(value1.ToString("#####"));
        // Debug.Log(string.Format("value1 is {0:#####}", value1));

        // float value2 = 1.23f;
        // Debug.Log(value2.ToString("0.0"));
        // Debug.Log(string.Format("Value2 is {0:0.00}", value2));

        // float value3 = 1234567890;
        // Debug.Log(value3.ToString("#,#"));
        // Debug.Log(string.Format("Value3 is {0:#,#}", value3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
