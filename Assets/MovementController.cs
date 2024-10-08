using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float movespeed = 5f;                    //Constant foward speed
    public float jumpforce = 10f;                  //Jump force
    public Transform groundCheckPoint;              //A point to check if the player is grounded
    public float checkRadius = 0.2f;                //Radius of the overlap circle for ground detection
    public LayerMask groundLayer;                   //Layer of the ground objects
    
    private Rigidbody2D rb;                         //Reference to the Rigidbody2D component
    private bool isGrounded;                        // Is the player on the ground?

    public AudioClip jump;
    public AudioClip CoinCollect;
     
    public AudioSource sfxPlayer;
    AudioSource playerSFX;
    public AudioSource musicPlayer;
    Animator anim;
     
    
    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();           // Get the Rigidbody2D component attached to the player
        anim = GetComponent<Animator>();
        playerSFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Constant foward movement
        rb.velocity = new Vector2(movespeed, rb.velocity.y);

        //Check if the player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, checkRadius, groundLayer);
        anim.SetBool("IsOnGround", isGrounded);

        //Jumping logic
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            Debug.Log("jump");
        }
    }

    private void Jump()
    {
        playerSFX.PlayOneShot(jump);
        //Add an upward force for jumping
        rb.velocity = new Vector2(rb.velocity.x, jumpforce);
       
        
    }

    private void OnDrawGizmosSelected()
    {
        //Draw a circle to visualize the ground check point in the editor
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckPoint.position, checkRadius);
    }


    }
