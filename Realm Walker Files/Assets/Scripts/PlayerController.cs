using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb2d;
    public float speed; 
    private float moveInput; //Reads input of gameObject for movement commands.
    public float jumpForce; //Adds jumping force to script component, determining how far can player jump.

    private bool isGrounded; //Sense of footing given to object, keeping gravity from having object continuously dropping.
    public Transform feetPos; //
    public float checkRadius; //Gives radius value for registering ground footing.
    public LayerMask Ground; //Gives gameObject reaction to objects with layer "Ground."

    // Use this for initialization
    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Animator ani;
        int attack = Animator.StringToHash("Attack");
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);
	}

    //Gives gameObject 
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, Ground);

        //Assigns key for jumping mechanism
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = Vector2.up * jumpForce;
        }
    }
}
