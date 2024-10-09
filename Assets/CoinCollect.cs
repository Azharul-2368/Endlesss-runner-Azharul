using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections;

public class CoinCollect : MonoBehaviour
{
    //public AudioClip coinMusic;
    public AudioClip playerSFX;
    public AudioSource playerSFXuhuhuh;
    GameObject obj;
    

    private void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        

        // Check if the object collidiing with the coin is the player
        if (other.gameObject.CompareTag("Player"))
        {
            playerSFXuhuhuh.PlayOneShot(playerSFX);

            //Debug.LogWarning("Working");
            // Add ay score incrementing logic here, e.g.;  
            // ScoreManager.instance.Addscore(1);


            ScoreScript.scoreValue += 1;
            //Destroy the coin when it hits the player
            Destroy(gameObject);
            ScoreManager.instance.AddPoint();
        }
    }
}