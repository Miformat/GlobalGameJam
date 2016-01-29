﻿using UnityEngine;
using System.Collections;

[AddComponentMenu("Camera-Control/Mouse Orbit with zoom")]
public class MouseOrbitImproved : MonoBehaviour
{

    public Transform target;
    public float distance = 5.0f;
    public float xSpeed = 120.0f;
    public float ySpeed = 120.0f;

    public float yMinLimit = -20f;
    public float yMaxLimit = 80f;

    /*public float distanceMin = .5f;
    public float distanceMax = 15f;*/

    //float x = 0.0f;
    float y = 0.0f;

    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Vector3 angles = transform.eulerAngles;
        //x = angles.y;
        y = angles.x;
    }
    
    void LateUpdate()
    {
        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
        
        y = ClampAngle(y, yMinLimit, yMaxLimit);
        Quaternion rotation = Quaternion.Euler(y, 0, 0);

        //distance = Mathf.Clamp(distance - Input.GetAxis("Mouse ScrollWheel") * 5, distanceMin, distanceMax);

        Vector3 negDistance = new Vector3(0.0f, 0.0f, -distance);
        Vector3 position = rotation * negDistance;

        transform.localRotation = rotation;
        transform.localPosition = position;
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }
}