using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = transform.position;
        Debug.Log($"{pos}");
        pos = new Vector3(0, 20, 0);
        Debug.Log($"{pos}");

        Transform trans = transform;
        trans.position = new Vector3(0, 20, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
