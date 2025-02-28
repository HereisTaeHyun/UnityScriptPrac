using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Form1 : MonoBehaviour
{
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        // button.onClick += new System.EventHandler(this.button1_Click);
        // button.onClick.AddListener(delegate {button1_Click});
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Debug.Log("버튼 1 클릭");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
