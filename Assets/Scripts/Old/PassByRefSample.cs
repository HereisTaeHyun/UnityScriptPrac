using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassByRefSample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 1;
        int b = 2;
        int c = 0;
        bool b1 = RefMethod(a, b, ref c);

        int d = 3;
        int e = 4;
        int f;
        bool b2 = OutMethod(d, e, out f);
    }

    bool RefMethod(int a, int b, ref int c)
    {
        c = a + b;
        return true;
    }

    bool OutMethod(int d, int e, out int f)
    {
        f = d + e;
        return true;
    }
}
