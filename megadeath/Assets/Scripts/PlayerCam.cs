using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
//goes on PlayerCam
public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;
    public float FOV = 90;

    public Transform orientation;

    float xRotation;
    float yRotation;

    private void Start()
    {
        DoFov();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        // get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // rotate cam and orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
    public void DoFov()
    {
        GetComponent<Camera>().DOFieldOfView(FOV, 0.25f);
    }
    public void DoFov(float endValue)
    {
        GetComponent<Camera>().DOFieldOfView(endValue, 0.25f);
    }
}
