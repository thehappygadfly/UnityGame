using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class thirdpersoncameracontroller : MonoBehaviour
{
    public float Cameraturnspeed = 1;
    public Transform Camerobject, Player;
    float mouseX, mouseY;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void LateUpdate()
    {

    }

    private void Cameracontrol()
    {
        mouseX += Input.GetAxis("Mouse X") * Cameraturnspeed;
        mouseY -= Input.GetAxis("Mouse Y") * Cameraturnspeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(Camerobject);
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Player.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        }
        else
        {
            Player.rotation = Quaternion.Euler(mouseY, mouseX, 0);
            Player.rotation = Quaternion.Euler(0, mouseY, 0);

        }
            

    }

}