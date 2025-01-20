using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class VariableType : MonoBehaviour
{
    // public bool staticVariable = true;
    // private int mGlovalVariable = 1;
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

        // int maxInt = int.MaxValue;
        // int minInt = int.MinValue;

        // Debug.Log($"abcde : {abCde}");
        // Debug.Log($"STR : {STR}");
        // Debug.Log($"maxInt : {maxInt}");
        // Debug.Log($"minInt : {minInt}");

        // int? nullInt = null;

        TimeSpan();
    }

    void LocalVariable(int param)
    {
        float localVariable = param;
    }

    void TimeSpan()
    {
        Stopwatch stopwatch = new Stopwatch();
        DateTime dt1 = new DateTime(2018, 08, 01, 02, 03, 04);
        DateTime dt2 = new DateTime(2019, 10, 20, 12, 00, 05);

        TimeSpan ts = dt2 - dt1;

        // 둘 사이 단순 마이너스 시간 차이
        stopwatch.Start();
        Debug.Log(ts.Days.ToString());
        Debug.Log(ts.Hours.ToString());
        Debug.Log(ts.Minutes.ToString());
        Debug.Log(ts.Seconds.ToString());

        // 둘 사이 실제 모든 지나간 시간 차이
        Debug.Log(ts.TotalHours.ToString());
        Debug.Log(ts.TotalMinutes.ToString());
        stopwatch.Stop();
        Console.WriteLine($"경과 시간 {stopwatch.ElapsedMilliseconds}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
