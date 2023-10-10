using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjctileForward : MonoBehaviour
{
    // taken from Unit 1
    //player gets pushed when shooting??
    //doesnt shoot the way aiming
    public float speed1 = 10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed1);
    }
}
