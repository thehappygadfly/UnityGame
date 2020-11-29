using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectitems : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name=="Player")
        {
            other.GetComponent<playercollectitems>().collectables++;
            Destroy(gameObject);
        }
    }
}
