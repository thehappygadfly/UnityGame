using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crate : MonoBehaviour
{
    public string InteractText { get; private set; }

    private bool mIsOpen = false;
    public void OnInteract()
    {
        InteractText = "Press F to open ";

        mIsOpen = !mIsOpen;
        InteractText = mIsOpen ? "to close" : "to open";

        GetComponent<Animator>().SetBool("open", mIsOpen);
    }


    
}
