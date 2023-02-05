using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraRotation : MonoBehaviour
{
    private CinemachineVirtualCamera virtualCamera;
    private CinemachineFramingTransposer FramingTransposer;
    public float moveSpeed = 0.01f;
    private float Hor = 0, Ver = 0;
    // Start is called before the first frame update
    void Start()
    {
        virtualCamera = gameObject.GetComponentInChildren<CinemachineVirtualCamera>();
        FramingTransposer = virtualCamera.GetCinemachineComponent<CinemachineFramingTransposer>();
    }

    // Update is called once per frame
    void Update()
    {
        Hor = (Input.GetAxis("Mouse X") * moveSpeed) + FramingTransposer.m_ScreenX;
        Ver = (Input.GetAxis("Mouse Y") * moveSpeed) + FramingTransposer.m_ScreenY;
        if (Hor >= 0.6f) {
            Hor = 0.6f;
        }
        if (Hor <= 0.4f)
        {
            Hor = 0.4f;
        }
        if (Ver >= 0.6f)
        {
            Ver = 0.6f;
        }
        if (Ver <= 0.4f)
        {
            Ver = 0.4f;
        }
        FramingTransposer.m_ScreenX = Hor;
        FramingTransposer.m_ScreenY = Ver;
    }
}
