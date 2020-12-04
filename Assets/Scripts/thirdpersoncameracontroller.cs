using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class thirdpersoncameracontroller : MonoBehaviour
{
    public float Cameraturnspeed = 0.4f;
    public Transform Camerobject, Player;
    float mouseX, mouseY;

    void Start()
    {
        Cursor.visible = true;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    private void Cameracontrol()
    {
        mouseX += Input.GetAxis("Mouse X") * Cameraturnspeed;
        mouseY -= Input.GetAxis("Mouse Y") * Cameraturnspeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(Camerobject);
        
        //if (Input.GetKey(KeyCode.LeftShift))
        //{
        //    Player.rotation = Quaternion.Euler(mouseY, mouseX, 0.001f);
        //}
        //else
        //{
        //    Player.rotation = Quaternion.Euler(mouseY, mouseX, 0.001f);
        //    Player.rotation = Quaternion.Euler(0, mouseY, 0.001f);

        //}
            

    }

}