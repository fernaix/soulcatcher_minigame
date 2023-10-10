using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // if left some notes from where I got some of the code from for future me. maybe itll save me 30 minutes of googling
    //i should make this look nicer
    //oh god i broke it somehow
    //there has to be a better way to

    // Add the variables
    public float speed = 100f; // Speed variable
    public Rigidbody rb; // Set the variable 'rb' as Rigibody
    public Vector3 movement; // Set the variable 'movement' as a Vector3 (x,y,z)

    private float horizontalInput;
    private float verticalInput;
    private float playerspeed = 10.0f;

    //objects
    public GameObject projectilePrefab; //prefab

    void Start()
    {
        // find the Rigidbody of this game object and add it to the variable 'rb'
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        // In Update we get the Input for left, right, up and down and put it in the variable 'movement'...
        // We only get the input of x and z, y is left at 0 as it's not required
        // 'Normalized' diagonals to prevent faster movement when two inputs are used together
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;

        //projectile controls
        if (Input.GetKeyDown(KeyCode.Space)) //launch projectile from the player
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        // 'FixedUpdate' Method is used for Physics movements
       // void FixedUpdate()
        {
            moveCharacter(movement); // We call the function 'moveCharacter' in FixedUpdate for Physics movement
        }

        // 'moveCharacter' Function for moving the game object
        void moveCharacter(Vector3 direction)
        {
            // We multiply the 'speed' variable to the Rigidbody's velocity...
            // and also multiply 'Time.fixedDeltaTime' to keep the movement consistant on all devices
            rb.velocity = direction * speed * Time.fixedDeltaTime;

            //player movement
            //horizontalInput = Input.GetAxis("Horizontal");
            // transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * playerspeed);

            //verticalInput = Input.GetAxis("Vertical");
            //transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * playerspeed);
        }
    }
}
    


