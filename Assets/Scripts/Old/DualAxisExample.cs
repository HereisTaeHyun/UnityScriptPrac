using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DualAxisExample : MonoBehaviour
{
    public float hRange;
    public float vRange;
    public TextMeshPro hTextOutput;
    public TextMeshPro vTextOutput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float hPos = h * hRange;
        float vPos = v * vRange;
        transform.position = new Vector3(hPos, 2f, vPos);
        hTextOutput.text = $"Horizontal value returned : {h:F2}";
        vTextOutput.text = $"Vertical value returned : {v:F2}";
    }
}
