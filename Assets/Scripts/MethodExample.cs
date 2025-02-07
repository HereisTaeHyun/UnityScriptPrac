using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int param1 = 1;
        int param2 = 2;
        int intmethod = IntMethod(param1, param2);
        Debug.Log(intmethod);

        float param3 = 3.5f;
        VoidMethod(param3.ToString());
    }

    int IntMethod(int p1, int p2)
    {
        return (p1 + p2);
    }

    void VoidMethod(string message)
    {
        Debug.Log("This is just Message");
    }

    void VoidMethod(float f1)
    {
        Debug.Log($"f1 : {f1}");
    }
}
