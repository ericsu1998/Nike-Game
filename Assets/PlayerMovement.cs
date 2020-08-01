using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool isGrounded = false;
    public Transform isGroundedChecker; // Place an empty game object and set layer to ground
    public float checkGroundRadius; // I set default to 0.05 but can adjust as necessary
    public LayerMask groundLayer; // Set all ground sprites' layers to ground

    private Rigidbody2D rb;

    public float jumpVelocity;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

	void CheckIfGrounded() { 
    	Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer); 
    	if (collider != null) { 
        	isGrounded = true; 
    	} else { 
        	isGrounded = false; 
    	} 
	}

    // Update is called once per frame
    void Update()
    {
    	CheckIfGrounded();
    	//Jumping
        if (Input.GetKeyDown(KeyCode.W) && isGrounded) {
        	//trying acceleration/gravity
        	rb.AddForce(transform.up * jumpVelocity);
        }
        if (Input.GetKey(KeyCode.A)) {
        	transform.position += new Vector3(-2, 0) * Time.deltaTime; // -2 is magic number, should make a variable for this
        }
        if (Input.GetKey(KeyCode.D)) {
        	transform.position += new Vector3(2, 0) * Time.deltaTime; // 2 is magic number, should make a variable for this
        }
    }

}
