using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 5;
    // Start is called before the first frame update
    void Start()
    {
        myInt = MultipleByTwo(myInt);
        Debug.Log($"int : {myInt}");
        Debug.LogError($"ErrorOn");
    }

    int MultipleByTwo(int target)
    {
        return target * 2;
    }

    // void Update()
    // {
    //     Debug.Log("HelloWorld");
    // }
}
