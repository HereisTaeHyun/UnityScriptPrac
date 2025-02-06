using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody bulletPrefeb;
    public Transform firePosition;
    public float bulletSpeed;

    private Inventory inventory;

    void Awake()
    {
        inventory = GetComponent<Inventory>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }

    void shoot()
    {
        if(Input.GetButtonDown("Fire1") && inventory.stuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefeb, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            inventory.stuff.bullets -= 1;
        }
    }
}
