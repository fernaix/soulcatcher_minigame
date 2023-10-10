using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookControl : MonoBehaviour
{

    // Start is called before the first frame update
    //sets player as object and offset
    private Vector3 offset = new Vector3(0, 20, 0);
    public GameObject player;

    public float rotMult = 4f;

    float yaw = 0f;
    float pitch = 0f;

    public float maxY = -65; // For some reason, the signs are strange.
    public float minY = 50;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        yaw += rotMult * Input.GetAxis("Mouse X");
        pitch -= rotMult * Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, maxY, minY); // Clamp viewing up and down

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        //camera follows player
        transform.position = player.transform.position; //+ offset;
    }
}


