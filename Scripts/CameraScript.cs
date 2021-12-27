using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {


    
    private const float Y_ANGEL_MIN = -50f, Y_ANGEL_MAX = 50.0f;

    public Transform m_LookAt;
    public Transform m_CamTransform;
    private Camera m_Cam;
    private float m_Distance = 10.0f, m_CurrentX = 0.0f, m_CurrentY = 0.0f, m_SensitivityX = 4.0f, m_SensitivityY = 1.0f;

	void Start ()
    {
        m_CamTransform = transform;
        m_Cam = Camera.main;
	}

    private void Update()
    {
        m_CurrentX += Input.GetAxis("Mouse X");
        m_CurrentY += Input.GetAxis("Mouse Y");

        m_CurrentY = Mathf.Clamp(m_CurrentY, Y_ANGEL_MIN, Y_ANGEL_MAX);
    }


    private void LateUpdate ()

    {
        Vector3 dir = new Vector3(0, 0, -m_Distance);
        Quaternion rotation = Quaternion.Euler(m_CurrentY, m_CurrentX, 0);
        m_CamTransform.position = m_LookAt.position + rotation * dir;
        m_CamTransform.LookAt(m_LookAt.position);
    }
}
