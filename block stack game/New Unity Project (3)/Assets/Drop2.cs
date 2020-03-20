using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Drop2 : MonoBehaviour
{

    public ScoreScript score;

    public AudioSource pointGet;

    public ParticleSystem spark;


    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.tag == "Player" )
        {
            Debug.Log("plus een");
            
            GameObject text = GameObject.Find("Text");
            score = text.GetComponent<ScoreScript>();
            score.scoreValue += 1;
            pointGet.Play();
            spark.Play();

        }
        else if(other.gameObject.tag == "zone")
        {
            SceneManager.LoadScene(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
