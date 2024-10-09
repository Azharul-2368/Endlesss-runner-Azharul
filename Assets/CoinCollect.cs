using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections;

public class CoinCollect : MonoBehaviour
{
    public AudioClip coinMusic;
    AudioSource playerSFX;
    GameObject obj;
    

    void start()
    {
        
        playerSFX = GetComponent<AudioSource>();
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        

        // Check if the object collidiing with the coin is the player
        if (other.gameObject.CompareTag("player")) ;
        {
            // Add ay score incrementing logic here, e.g.;  
                // ScoreManager.instance.Addscore(1);
           
            ScoreScript.scoreValue += 1;
            //Destroy the coin when it hits the player
            Destroy(gameObject);
            ScoreManager.instance.AddPoint();
        }
    }
}