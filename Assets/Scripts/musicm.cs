using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicm : MonoBehaviour
{
    private static musicm musicmInstance;
    private void Awake()
    {
        DontDestroyOnLoad(this);
    
        if (musicmInstance == null)
        {
            musicmInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    

}
