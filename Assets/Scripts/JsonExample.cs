using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class JsonData
{
    public string name;
    public int age;
    public float height;
    public bool man;
    public string description;
    public string[] tools;
}

public class JsonExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        JsonData[] jsonDatas = new JsonData[2];
        jsonDatas[0] = new JsonData();
        jsonDatas[0].name = "Michel";
        jsonDatas[0].age = 24;
        jsonDatas[0].height = 165;
        jsonDatas[0].man = false;
        jsonDatas[0].description = "";
        jsonDatas[0].tools = new string[3];
        jsonDatas[0].tools[0] = "Unity";
        jsonDatas[0].tools[1] = "Visual Studio";
        jsonDatas[0].tools[2] = "Photoshop";

        jsonDatas[1] = new JsonData();
        jsonDatas[1].name = "Jason";
        jsonDatas[1].age = 45;
        jsonDatas[1].height = 173;
        jsonDatas[1].man = true;
        jsonDatas[1].description = "team reader";
        jsonDatas[1].tools = new string[4];
        jsonDatas[1].tools[0] = "Unity";
        jsonDatas[1].tools[1] = "Unreal";
        jsonDatas[1].tools[2] = "Visual Studio";
        jsonDatas[1].tools[3] = "Photoshop";

        string toJson0 = JsonUtility.ToJson(jsonDatas[0]);
        Debug.Log(toJson0);

        string toJson1 = JsonUtility.ToJson(jsonDatas[1]);
        Debug.Log(toJson1);

        JsonData fromJson = JsonUtility.FromJson<JsonData>(toJson0);
        Debug.Log(fromJson.name);

        File.WriteAllText(@"C:\JsonExample.json", toJson1);

        string readJson = File.ReadAllText(@"C:\JsonExample.json");
        Debug.Log(readJson);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
