using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    //Much like the start() and Update() methods,OnTriggerEnter2D is a special Unity method that is called
    //by Unity automatically at a sspecific point - in this case when something enters the trigger attatched
    //to this gameobject
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If the gameobject that ha collidd with our trigger is tagged with cleanup...
        if (collision.gameObject.tag == "CleanUp")
        {
            //Then we use this method to destroy it.
            Destroy(collision.gameObject);
        }
    }
}