using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField]float yaxis = 5;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,yaxis,0);
    }
}
