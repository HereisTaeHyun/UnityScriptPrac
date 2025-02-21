using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Another;

public class NamespaceExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("namespace");

        // var ns = new NamespaceDefinitionExample();
        // ns.Debuglog("namespace");

        NamespaceDefinitionExample.StaticSample();

        Debug.Log(NamespaceDefinitionExample.GetData(10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int GetData(int a)
    {
        return 1;
    }
}
