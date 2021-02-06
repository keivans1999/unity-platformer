using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeeed;
    public Rigidbody2D rb; //velocity and forces 
    
    public float jumpForce = 20f;
    public Transform feet;
    public LayerMask groundLayers;

    float mx;   //movement for the x-axis
    bool isGrounded;

    private void Update() //Update is called once per frame
    { 
        mx = Input.GetAxisRaw("Horizontal"); // class to get the value of virtual axis without virtual smoothering. Should get x-axis.
    
        if (Input.GetButtonDown("Jump") && IsGrounded()) {
            Jump();
        }
    }

    /*
    void Start() //Start is called before the first frame update
    {

    }
    */

    private void FixedUpdate() 
    {
        Vector2 movement = new Vector2(mx * movementSpeeed, rb.velocity.y);
        rb.velocity = movement;
    }

    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);
        rb.velocity = movement;
    }

    public bool IsGrounded() 
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);

        if (groundCheck != null)
        {
            return true;
        }
        return false; 
        
    }


    
 
}
