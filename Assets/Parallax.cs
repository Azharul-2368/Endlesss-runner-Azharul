using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    GameObject player; //Reference tp the player so we can track its position
    Renderer rend; //Reference to the renderer so we can modify its texture

    float playerStartPos; //Float used to track the starting position of the player
    public float speed = 0.5f;//how fast  should we scroll? We change this for each layer

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player"); //Find the player
        rend = GetComponent<Renderer>(); //Save our starting position

    }

    // Update is called once per frame
    void Update()
    {
        float offset = (player.transform.position.x - playerStartPos) * speed;
        //^^^^^^^^^^^^^^^^^^^^This line finds out much to offset the texture by
        //we do this by subtracting out starting x posisiton from our current x position
        //we then multiply the offset by the speed, so that we can have different layers moving at different speeds

        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0f));
        //^^^^^^^^^^^^^^^^^^^^^^This line sets our texture 'offset'. 
        //we use the  setTxtureMethod to do this which takes 2 parameters
        //The first parameter is a string that refers to the texture we want to modify
        //The second parameter is a Vector2 with the first (X) variable shifting the tecture
        //Lef6t and right and the second (Y) variable shifting the texture up and down
    }
}
