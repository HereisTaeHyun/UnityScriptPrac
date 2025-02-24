using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericExample : MonoBehaviour
{
    public class Generic<T>
    {
        private T value;
        public Generic(T value)
        {
            this.value = value;
        }

        public void Method1()
        {
            Debug.Log(value);
        }
    }
    // void Start()
    // {
    //     Generic<int> genericClass1 = new Generic<int>(4);
    //     genericClass1.Method1();
    //     Generic<float> genericClass2 = new Generic<float>(0.47f);
    //     genericClass2.Method1();
    // }

    void Swap<T>(ref T x, ref T y)
    {
        var temp = y;
        y = x;
        x = temp;
    }

    void Start()
    {
        int ix = 1, iy = 2;
        Debug.Log($"ix = {ix}, iy = {iy}");
        Swap(ref ix, ref iy);
        Debug.Log($"ix = {ix}, iy = {iy}");

        string sx = "ab", sy = "cd";
        Debug.Log($"ix = {sx}, iy = {sy}");
        Swap(ref sx, ref sy);
        Debug.Log($"ix = {sx}, iy = {sy}");
    }
}
