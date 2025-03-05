using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] float speed = 30;
    float y = 0f;
    
    void Start()
    {
        Instruction();
    }

    // Update is called once per frame
    void Update()
    {
        movement(); 
    }

    void Instruction()
    { 
        Debug.Log("yo!! welcome to the game ");
        Debug.Log("Doge the obstacles");
    }

    void movement()
    {
        float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        transform.Translate(x, y, z);
    }
}
