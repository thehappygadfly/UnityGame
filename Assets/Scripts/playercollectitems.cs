using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollectitems : MonoBehaviour
{
    public int collectables = 0;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 10), "Collectables: " + collectables);
    }
}
