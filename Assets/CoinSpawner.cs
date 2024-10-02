using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    //Reference to the coin prefab
    public GameObject coinPrefab;
    public AudioSource AudioSource;

    //define the offset or range where the coin shouls spawn on the platform.
    public Vector2 coinOffset = new Vector2(0, 1); //Adjust as necessary


    // Start is called before the first frame update
    void Start()
    {
        //spawn the coin on the platform at the desired position
        SpawnCoin();

    }

    // Update is called once per frame
    void SpawnCoin()
    {
        //calculate the coin position relative to the platform
        Vector3 coinPosition = transform.position + (Vector3)coinOffset;

        //Instantiate the coin at the calculated position
        Instantiate(coinPrefab, coinPosition, Quaternion.identity);


    }
}
