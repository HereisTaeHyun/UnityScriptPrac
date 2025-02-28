using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Anony : MonoBehaviour
{
    // Start is called before the first frame update
    delegate int MyDelegate(int a, int b);
    void Start()
    {
        MyDelegate sum1;
        MyDelegate sum2;
        sum1 = RunDelegate;
        sum2 = delegate(int a, int b) { return a * b; };
    }

    private int RunDelegate(int a, int b)
    {
        return a * b;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
