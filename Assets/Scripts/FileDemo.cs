using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Unity.VisualScripting;
using System;

public class FileDemo : MonoBehaviour
{
    public string filePath = @"C:\temp\MyTest.txt";
    private FileInfo fileInfo;
    // Start is called before the first frame update

    private void Start()
    {
        fileInfo = new FileInfo(filePath);
        using(StreamWriter sw = File.CreateText(filePath))
        {
            sw.WriteLine("Hello");
            sw.WriteLine("And");
            sw.WriteLine("Welcome");
        }

        using (StreamReader sr = fileInfo.OpenText())
        {
            var s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Debug.Log(s);
            }
        }

        try
        {
            string filePath2 = Path.GetTempFileName();
            var fileInfo2 = new FileInfo(filePath2);
            fileInfo2.Delete();
            fileInfo.CopyTo(filePath);
            Debug.Log($"{filePath} was copied to {filePath2}");
            fileInfo2.Delete();
            Debug.Log($"{filePath2} deleted");
        }
        catch(Exception e)
        {
            Debug.Log($"The process failed {e.ToString()}");
        }
    }
    // void Start()
    // {
    //     if(!File.Exists(filePath))
    //     {
    //         using(StreamWriter sw = File.CreateText(filePath))
    //         {
    //             sw.WriteLine("Hello");
    //             sw.WriteLine("And");
    //             sw.WriteLine("Welcome");
    //         }
    //     }

    //     using (StreamReader sr = File.OpenText(filePath))
    //     {
    //         string s;
    //         while ((s = sr.ReadLine()) != null)
    //         {
    //             Debug.Log(s);
    //         }
    //     }
    // }

    // Update is called once per frame
    void Update()
    {
        
    }
}
