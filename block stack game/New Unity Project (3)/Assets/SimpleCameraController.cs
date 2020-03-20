using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCameraController : MonoBehaviour
{

    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey ("w")){
            transform.position += transform.TransformDirection (Vector3.up) * Time.deltaTime * movementSpeed;
        }    
    }
}

