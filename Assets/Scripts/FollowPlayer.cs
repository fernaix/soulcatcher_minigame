using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //sets player as object and offset
    private Vector3 offset = new Vector3 (0, 20, 0);
    public GameObject player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //camera follows player
        transform.position = player.transform.position + offset;
        //transform.position = player.transform.position + new Vector3(0, 1, 10);

    }
}
