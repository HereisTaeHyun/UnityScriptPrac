using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AxisExample : MonoBehaviour
{
    public float range;
    public TextMeshPro textOutPut;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        // float h = Input.GetAxisRaw("Horizontal");
        float xPos = h * range;
        transform.position = new Vector3(xPos, 2f, 0);
        textOutPut.text = "Value Returned" + h.ToString("F2");
    }
}
