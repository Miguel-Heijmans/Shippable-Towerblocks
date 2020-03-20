using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeSpawner : MonoBehaviour
{

    public bool isFiring;

    public Drop2 cube;
    

    public float timeBetweenShots;
    private float shotCounter;

    public Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isFiring)
        {
            shotCounter -= Time.deltaTime;
            if(shotCounter <0)
            {
               shotCounter = timeBetweenShots;
               Drop2 newCube = Instantiate(cube, firePoint.position, firePoint.rotation) as Drop2;
               
            }
        } 
        else 
        {
             
            shotCounter = 0;

        }

        if(Input.GetKey(KeyCode.Space))
        {
            isFiring = true;
        }
        else
        {
            
            isFiring = false;
        }
    } 
}

