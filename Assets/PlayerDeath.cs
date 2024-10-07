using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public float fallThreshold = -10f;  //yposition at which player dies
    private DeathManager deathManager;  //reference to the deathmanaager script 


    void Start()
    {
        //get refernce to the deathmanager
        deathManager = FindObjectOfType<DeathManager>();
    }


    void update()
    {

        //check if the player falls below the threshhold
        if (transform.position.y < fallThreshold)
        {
            //call the method  to show the death screen
            deathManager.ShowDeathScreen();
        }
    }
}