﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    private Rigidbody2D rb2d; //Applies physics components
    public float speed; //Adds speed value for object's movements
    public Transform target;

    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask Ground;

    // Use this for initialization
    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); //Targets gameObject with tag "Player."
	}
	
	// Update is called once per frame
    //If statement commanding gameObject to follow target if near certain distance.
	void Update ()
    {
        if (Vector2.Distance(transform.position, target.position) > 2)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
	}
}
