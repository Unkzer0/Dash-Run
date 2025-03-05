using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rb;
    void Start()
    {
        Debug.Log("seconds have left" + sec);
        renderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rb.useGravity = false;
    }

    [SerializeField]float sec = 1;
    void Update()
    {
        if (Time.time > sec)
        {
            
            renderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
