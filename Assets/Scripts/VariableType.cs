using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableType : MonoBehaviour
{
    public bool staticVariable = true;
    private int mGlovalVariable = 1;
    public int abCde = 1; // 유니티 에디터 상으로 조작 가능
    public string STR = "Hi, World";
    const float pi = 3.14f;
    // Start is called before the first frame update
    void Start()
    {
        // int localVariable1 = 1;
        // Debug.Log(localVariable1.ToString());
        // int localVariable2;
        // Debug.Log(localVariable2.ToString());
        // LocalVariable(1);

        int maxInt = int.MaxValue;
        int minInt = int.MinValue;

        Debug.Log($"abcde : {abCde}");
        Debug.Log($"STR : {STR}");
        Debug.Log($"maxInt : {maxInt}");
        Debug.Log($"minInt : {minInt}");
    }

    void LocalVariable(int param)
    {
        float localVariable = param;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
