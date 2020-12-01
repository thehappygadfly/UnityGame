using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectitems : MonoBehaviour
{
    public AudioClip coinsound;
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
            AudioSource.PlayClipAtPoint(coinsound, transform.position);
            Destroy(gameObject);
        }
    }
}
