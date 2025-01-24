using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeyInput : MonoBehaviour
{
    public Image graphic;
    public Sprite standard, downgfx, upgfx, heldgfx;
    public TextMeshProUGUI boolDisplay1, boolDisplay2, boolDisplay3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");

        if(down)
        {
            graphic.sprite = downgfx;
        }
        else if(held)
        {
            graphic.sprite = heldgfx;
        }
        else if(up)
        {
            graphic.sprite = upgfx;
        }
        else
        {
            graphic.sprite = standard;
        }

        boolDisplay1.text = " " + down;
        boolDisplay2.text = " " + held;
        boolDisplay3.text = " " + up;
    }
}
