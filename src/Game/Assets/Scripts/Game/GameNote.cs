using UnityEngine;
using System.Collections;

public class GameNote : MonoBehaviour {

    public float moveSpeed = 0.09f;
    public GameObject hitbox;

    void FixedUpdate()
    {
        //Movement towards the hitbox object
        transform.position = Vector3.MoveTowards(transform.position, hitbox.transform.position, moveSpeed);
    }
    
    //If coliding with the trigger
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hitSuccess();
        }
    }

    //If did collide but wasn't destroyed yet the player hit it wrong
    void OnTriggerExit(Collider other)
    {
        hitFail();
    }

    void hitSuccess()
    {
        Destroy(this.gameObject);
        
        //Set the score
        //Set the accuracy
        //Play the particle

        //var distanceFromCenter = transform.position - hitbox.transform.position;

        //if(distanceFromCenter.z > 1.5)
    }

    void hitFail()
    {
        //Destroy(this);
    }
}
