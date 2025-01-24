using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Operator : MonoBehaviour
{
    private int result = 0;
    // Start is called before the first frame update
    void Start()
    {
        List<int> lst = new List<int>();
        int intSize = sizeof(int);
        long longSize = sizeof(long);
        float floatSize = sizeof(float);
        int boolSize = sizeof(bool);
        Debug.Log($"int : {intSize}, long : {longSize} float : {floatSize}, bool : {boolSize}");

        int i = 1;
        Debug.Log($"Before : {i}");
        Debug.Log($"++i : {++i}");
        Debug.Log($"after : {i}");

        i = 1;
        Debug.Log($"Before : {i}");
        Debug.Log($"i++ : {i++}");
        Debug.Log($"after : {i}");

        i = 1;
        object iBoxed = i;
        Debug.Log((iBoxed is int).ToString());
        Debug.Log((iBoxed is float).ToString());
    }

    // Update is called once per frame
    void Update()
    {
    }
}
