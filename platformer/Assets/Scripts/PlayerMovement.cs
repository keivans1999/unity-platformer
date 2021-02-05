using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeeed;
    public Rigidbody2D rb; //velocity and forces 
    
    float mx;   //movement for the x-axis
    //float my;  //movement for the y-axis

    private void Update() 
    { 
        mx = Input.GetAxisRaw("Horizontal"); // class to get the value of virtual axis without virtual smoothering. Should get x-axis.
    }

    private void FixedUpdate() {
        Vector2 movement = new Vector2(mx * movementSpeeed, rb.velocity.y);

        rb.velocity = movement;
    }




    
 
}
