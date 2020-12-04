using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectitems : MonoBehaviour
{
    public AudioClip gemsound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name=="Player")
        {
            other.GetComponent<playercollectitems>().collectables++;
            AudioSource.PlayClipAtPoint(gemsound, transform.position);
            Destroy(gameObject);
        }
    }
}
