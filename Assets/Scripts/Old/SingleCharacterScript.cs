using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleCharacterScript : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int rockets;
        public int grenades;
        public Stuff(int bul, int roc, int gre)
        {
            this.bullets = bul;
            this.rockets = roc;
            this. grenades = gre;
        }
    }

    public Stuff stuff = new Stuff(10, 7, 25);
    public float speed;
    public float turnSpeed;
    public Rigidbody bulletPrefeb;
    public Transform firePosition;
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shoot();
    }

    private void Movement()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }

    private void Shoot()
    {
        if(Input.GetButtonDown("Fire1") && stuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefeb, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            stuff.bullets -= 1;
        }
    }
}
