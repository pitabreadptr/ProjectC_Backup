using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCharacter : MonoBehaviour {
    [Header("Camera")]
    public Transform cam;
    public bool lockCursor;

    [Range(0.1f, 10)] public float lookSensitivity;

    public float maxUpRotation;
    public float maxDownRotation;

    private float xRotation = 0;

    [Header("Movement")]
    public CharacterController controller;

    // Speed of forwards and backwards movement
    [Range(0.5f, 20)] public float walkSpeed;

    // Speed of sideways (left and right) movement
    [Range(0.5f, 15)] public float strafeSpeed;

    public KeyCode sprintKey;

    // How many times faster movement along the X and Z axes
    // is when sprinting
    [Range(1, 3)] public float sprintFactor;

    private Vector3 velocity = Vector3.zero;

    void Start() {
        lookSensitivity = PlayerPrefs.GetFloat("currentSensitivity", 10);
        if(lockCursor) {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    void Update() {



            transform.Rotate(0, Input.GetAxis("Mouse X") * lookSensitivity, 0);
            xRotation -= Input.GetAxis("Mouse Y") * lookSensitivity;
            xRotation = Mathf.Clamp(xRotation, -maxUpRotation, maxDownRotation);
            cam.localRotation = Quaternion.Euler(xRotation, 0, 0);

            velocity.z = Input.GetAxis("Vertical") * walkSpeed;
            velocity.x = Input.GetAxis("Horizontal") * strafeSpeed;
            velocity = transform.TransformDirection(velocity);

            if (Input.GetKey(sprintKey)) { Sprint(); }

            // Apply manual gravity
            velocity.y += Physics.gravity.y * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
    }

    private void Sprint()
    {
        velocity.z *= sprintFactor;
        velocity.x *= sprintFactor;
    }

}