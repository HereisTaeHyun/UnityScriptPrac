using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    // 전역 변수는 기본 값이 지정되나 지역 변수는 그렇지 않다
    int g;
    // Start is called before the first frame update
    void Start()
    {
        int g2;
        var i = 1;
        var f = 2f;
        var c = 'c';
        var s = "str";

        int age = 46, room = 402;
        float f1 = 2.4f, f2 = 80.5f;
        int i1 = 45, i2 = 20;
        var v1 = 1;

        string str1 = "abc";
        string str2 = new string("abc");

        int num1;
        num1 = 1;
        int changed = 50;
        float num3 = 4f, num4 = 7f;
        bool isBool = true;

        // Debug.Log(num1.ToString());
        // Debug.Log(changed.ToString());
        // Debug.Log(num3.ToString());
        // Debug.Log(num4.ToString());
        // Debug.Log(isBool.ToString());
        Debug.Log(g);
        // Debug.Log(g2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
