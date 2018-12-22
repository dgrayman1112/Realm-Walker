using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int health; //Assigns health in gameObject's script component.
    public float speed; //Assigns speed for gameObject's movement.

    private Animator anim;
    public GameObject bloodEffect;

	// Use this for initialization.
	void Start ()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isRunning", true);
	}
	
	// Update is called once per frame
    //Causes gameObject to dissapear if health counter is 0 or less. 
	void Update ()
    {
		if(health <= 0)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime);
	}

    //Allows inflicting damage to enemy.
    public void TakeDamage(int damage)
    {
        Instantiate(bloodEffect, transform.position, Quaternion.identity);
        health -= damage;
        Debug.Log("damage taken !");
    }

}
