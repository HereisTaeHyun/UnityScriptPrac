using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingDeltaTime : MonoBehaviour
{
    public float speed = 8f;
    [Range(1f, 10f)]
    public float countDown = 3f;
    public Light light;
    void Update()
    {
        countDown -= Time.deltaTime;
        if(countDown <= 0f)
        {
            light.enabled = false;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
        }
    }
}
