using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour
{
    public Rigidbody rocketPrefeb;
    public Transform barrelEnd;
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefeb, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstance.AddForce(barrelEnd.up * 5000);
        }
    }
}
