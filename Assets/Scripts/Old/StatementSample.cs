using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatementSample : MonoBehaviour
{
    enum Avengers {IronMan, SpiderMan, Hulk}
    // Start is called before the first frame update
    void Start()
    {
        Avengers avengers = Avengers.IronMan;

        switch(avengers)
        {
            case Avengers.Hulk:
                Debug.Log("Hulk");
                break;

            case Avengers.IronMan:
                Debug.Log("Hulk");
                break;

            case Avengers.SpiderMan:
                Debug.Log("Hulk");
                break;
            default:
                Debug.Log("Not Avengers");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
