using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crate : PlayerMovement
{
    public string InteractText { get; private set; }

    private bool mIsOpen = false;
    public override void OnInteract()
    {
        InteractText = "Press F to open ";

        mIsOpen = !mIsOpen;
        InteractText = mIsOpen ? "to close" : "to open";

        GetComponent<Animator>().SetBool("open", mIsOpen);
    }


    
}
