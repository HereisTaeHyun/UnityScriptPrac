using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roop : MonoBehaviour
{
    int numEnemies = 3;
    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
}
