using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItemBase : MonoBehaviour
{
    public string Name;
    public Sprite Image;
    public string InteractText = "Press F to pick up Item";

    public virtual void OnInteract()
    {


    }

}
