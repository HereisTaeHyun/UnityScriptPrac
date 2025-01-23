using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class StringExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string msg1 = "message";
        string msg2 = null; //값이 할당되지 않음
        string msg3 = ""; //빈 칸을 할당
        string msg4 = string.Empty; // 빈칸 할당으로 3과 동일
        
        string name = "Coder Zero";
        char[] charArray = name.ToCharArray();
        Debug.Log(charArray[1]);

        string s = new string(charArray);
        Debug.Log(s);

        StringBuilder sb = new StringBuilder("StringBuilder1");
        sb.Append("StringBuilder1");
        Debug.Log(sb);

        var sb1 = new StringBuilder("Coder");
        sb1.Append("Zero");
        Debug.Log(sb1);

        var sb2 = new StringBuilder("Unity #");
        sb2.Insert(6, "C");
        Debug.Log(sb2);

        var sb3 = new StringBuilder("Code Zero");
        sb3.Remove(6, 3);
        Debug.Log(sb3);

        var sb4 = new StringBuilder("coder zero");
        sb4.Replace('z', 'Z');
        Debug.Log(sb4);
        
        var sb5 = new StringBuilder("Coder Zero Visual C#");
        sb5.Replace("Visual", "Unity");
        Debug.Log(sb5);

        var sb6 = new StringBuilder("Coder zero Unity C#");
        sb6.Replace('u', 'U', 0, 12);
        Debug.Log(sb6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
