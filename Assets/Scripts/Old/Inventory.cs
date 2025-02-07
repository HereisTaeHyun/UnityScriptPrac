using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int rockets;
        public int grenades;
        public float fuel;

        public Stuff(int bul, int roc, int gre)
        {
            this.bullets = bul;
            this.rockets = roc;
            this.grenades = gre;
        }

        public Stuff(int bul, float fu)
        {
            this.bullets = bul;
            this.fuel = fu;
        }

        public Stuff()
        {
            this.bullets = 1;
            this.rockets = 1;
            this.grenades = 1;
        }
    }

    public Stuff stuff = new Stuff(50, 5, 5);
    public Stuff otherStuff = new Stuff(50, 1.5f);
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(stuff.bullets); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
