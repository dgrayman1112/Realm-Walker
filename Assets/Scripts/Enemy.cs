﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int health;
    public float speed;

    private Animator anim;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(health <= 0)
        {
            Destroy(gameObject);
        }
	}

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("damage taken !");
    }

}
