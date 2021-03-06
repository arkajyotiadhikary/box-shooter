﻿using UnityEngine;

public class plyer_look : MonoBehaviour
{
    // Floats
    public float mouseSense;
    public float lookUp, lookDown;
    
    // Transforms
    public Transform look;
    public Transform right_hand;
    public Transform camera;

    // Vector3
    Vector3 currentLook;
    Vector3 lookAngle;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentLook = new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);

        lookAngle.x += currentLook.x * -mouseSense * Time.deltaTime;
        
        lookAngle.x = Mathf.Clamp(lookAngle.x, -lookDown, lookUp);

        lookAngle.y += currentLook.y *mouseSense* Time.deltaTime;

        this.transform.rotation = Quaternion.Euler(0, lookAngle.y, 0);
        look.rotation = Quaternion.Euler(lookAngle.x, lookAngle.y, 0);
        right_hand.forward = camera.forward;
    }
}
