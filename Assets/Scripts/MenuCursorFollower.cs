using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCursorFollower : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    private float yaw = -136.025f, pitch = 15.185f;

    // Update is called once per frame
    void Update()
    {
        yaw += Input.GetAxis("Mouse X") * moveSpeed;
        pitch -= Input.GetAxis("Mouse Y") * moveSpeed;
        if (yaw <= -140f) 
        {
            yaw = -140f;
        }
        if (yaw >= -135f)
        {
            yaw = -135f;
        }
        if (pitch <= 12.5f)
        {
            pitch = 12.5f;
        }
        if (pitch >= 17.5f)
        {
            pitch = 17.5f;
        }

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
