using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    //lets player move side to side and forward
    private float horizontalInput;
    private float verticalInput;

    //speed of movement
    private float playerspeed = 10.0f;

    public GameObject projectilePrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //launch projectile from the player
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }


        //player movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.back * horizontalInput * Time.deltaTime * playerspeed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * verticalInput * Time.deltaTime * playerspeed);
    }


}

