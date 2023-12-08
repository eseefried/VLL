using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//put this script on a gameObject
//set newObject in inspector
//update desired tag
public class cookCollider : MonoBehaviour
{
    // This function is called when gameObject collides with another collider
    public GameObject newObject;
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with ObjectB
        if (collision.gameObject.CompareTag("cook")) // Check if this is the action object
        {
            Instantiate(newObject, transform.position, transform.rotation); //Add the new object
            Destroy(gameObject); // Destroy the current object
        }
    }
}
