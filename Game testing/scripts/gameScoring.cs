using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameScoring : MonoBehaviour
{
    
    public string targetTag="enemy"; // The tag of the target object we want to detect collisions with
    public int health = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health<=0){
            Debug.Log("You Loss");
            Application.Quit();
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            // Collision detected with object of the target tag
            Debug.Log("Collision detected with object of tag " + targetTag);
            health=health-1;
            // Do something here, like destroy the collided object
            //Destroy(collision.gameObject);
        }
        if(collision.gameObject.CompareTag("Home")){
                Debug.Log("You Won");
        }
    }
}
