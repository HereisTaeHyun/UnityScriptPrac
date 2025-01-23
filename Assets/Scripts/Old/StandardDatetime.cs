using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class StandardDatetime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DateTime dt = new DateTime(2025, 01, 22, 13, 23, 35);

        Debug.Log(dt.ToString());

        Debug.Log(dt.ToString("d", CultureInfo.CreateSpecificCulture("en-US")));

        Debug.Log(dt.ToString("D", CultureInfo.CreateSpecificCulture("ja-JP")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"), $"{dt:D}"));

        Debug.Log(dt.ToString("F", CultureInfo.CreateSpecificCulture("en-US")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"), $"{dt:F}"));

        Debug.Log(dt.ToString("U", CultureInfo.CreateSpecificCulture("ja-JP")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"), $"{dt:U}"));

        Debug.Log(string.Format("{0:yyyymmmmdddd}", dt));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
