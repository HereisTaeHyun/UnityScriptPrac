using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class Class1 : MonoBehaviour
{
    private Class2 m_class2 = new Class2();
    private Class2 m_class3 = new Class2(100);
    [SerializeField] private int pro;
    public int Pro
    {
        get{return this.pro;}
        set{this.pro = value;}
    }
    void Start()
    {
        m_class2.DebugLog("HelloWorld");
    }
}

public class Class2
{
    private int m_intVariable;
    private string m_StringVatiable;

    private int property;
    // public int Property
    // {
    //     get{return this.property;}
    //     set{this.property = value;}
    // }
    // public int Property{get;set;}
    public int Property{get; private set;}
    public Class2()
    {

    }
    public Class2(int a)
    {

    }
    public void DebugLog(string message)
    {
        m_StringVatiable = message;
        Debug.Log(message);
        Debug.Log(message);
    }
}

public static class Class3
{
    public static int INTNUM;
    public static int someNum;
}