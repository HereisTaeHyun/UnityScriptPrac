using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class InvokeRepeating : MonoBehaviour
{
    public GameObject target;
    enum State {make, stop}
    State state = State.stop;
    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("SpawnObject", 1, 1); // 2초 후 시작하여 1초 간격으로 지속
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(state == State.make)
            {
                CancelInvoke("SpawnObject");
                state = State.stop;
            }
            else if(state == State.stop)
            {
                InvokeRepeating("SpawnObject", 1, 1);
                state = State.make;
            }
        }
    }

    // Update is called once per frame
    void SpawnObject()
    {
        int a = Random.Range(1, 10);
        float x = Random.Range(-2.0f, 2.0f);
        float y = Random.Range(-2.0f, 2.0f);
        Instantiate(target, new Vector3(x, 2, y), Quaternion.identity);
    }
}
