using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorer : MonoBehaviour
{    
    int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {  
        if (collision.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("hit scorer " + hits);
        }
    }
}
