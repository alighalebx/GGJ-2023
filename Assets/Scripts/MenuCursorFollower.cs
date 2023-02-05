using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCursorFollower : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    [SerializeField] float startX;
    [SerializeField] float startY;
    [SerializeField] float yRightLimit;
    [SerializeField] float yLeftLimit;
    [SerializeField] float xUpLimit;
    [SerializeField] float xDownLimit;
    private float yaw, pitch;

    private void Start()
    {
        yaw = startY; pitch = startX;
        Time.timeScale = 1;
    }

    void Update()
    {

        yaw += Input.GetAxis("Mouse X") * moveSpeed;
        pitch -= Input.GetAxis("Mouse Y") * moveSpeed;
        if (yaw <= yLeftLimit) 
        {
            yaw = yLeftLimit;
        }
        if (yaw >= yRightLimit)
        {
            yaw = yRightLimit;
        }
        if (pitch <= xDownLimit)
        {
            pitch = xDownLimit;
        }
        if (pitch >= xUpLimit)
        {
            pitch = xUpLimit;
        }

        transform.eulerAngles = new Vector3(pitch, yaw, -3.209f);
    }
}
