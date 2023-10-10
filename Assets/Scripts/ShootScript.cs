using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

    public Rigidbody projectilePrefab;
    public float shootSpeed = 10f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shootBullet();
        }
    }
    void shootBullet()
    {
        //instantiates a new bullet
        var projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        //shooty the bullet
        projectile.velocity = transform.forward * shootSpeed;
    }
}
