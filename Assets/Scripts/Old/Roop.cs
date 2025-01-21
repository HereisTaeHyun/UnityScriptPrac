using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Roop : MonoBehaviour
{
    int numEnemies = 3;
    // Start is called before the first frame update
    void Start()
    {
        // ForLoop();
        ForEach();
    }

    void ForLoop()
    {
        for(int i = 1; i <= numEnemies; i++)
        {
            Debug.Log($"Creating Enemy : {i}");
        }
        for(int i = numEnemies; i >= 0; i--)
        {
            Debug.Log($"Deleting Enemy : {i}");
        }
    }

    void WhileLoop()
    {
        int cupInSink = 4;
        while (cupInSink > 0)
        {
            Debug.Log($"cupInSinkNow : {cupInSink}");
            cupInSink--;
        }

        Debug.Log("For version");

        cupInSink = 4;
        for(int i = cupInSink; i > 0; i--)
        {
            Debug.Log($"cupInSinkNow : {i}");
        }
    }

    void DoWhileLoop()
    {
        bool shouldContinue = false;

        do
        {
            Debug.Log("Hello");
        } while(shouldContinue == true);
    }

    void ForEach()
    {
        string[] strings = new string[3];

        strings[0] = "First";
        strings[1] = "Second";
        strings[2] = "Third";

        foreach(var elem in strings)
        {
            Debug.Log(elem);
        }

        Debug.Log("For version");

        for(int i = 0; i < strings.Length; i++)
        {
            Debug.Log(strings[i]);
        }
    }

    // Update is called once per frame
}
