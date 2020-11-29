using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crate : MonoBehaviour
{
    private bool mIsOpen = false;

     void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            mIsOpen = !mIsOpen;

            GetComponent<Animator>().SetBool("open", mIsOpen);
        }
    
    }


    
}
