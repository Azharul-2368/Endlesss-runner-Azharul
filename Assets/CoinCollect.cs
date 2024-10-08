using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    
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