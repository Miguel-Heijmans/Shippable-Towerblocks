using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Drop : MonoBehaviour
{

    public AudioSource spawn;
    

    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            
            GetComponent<Animator>().enabled = false;

            

            transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f , transform.position.z);
            

           spawn.Play();
           
        
        }


        if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * 6;
        }
        else if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * 6;
        }

        
    }
}
