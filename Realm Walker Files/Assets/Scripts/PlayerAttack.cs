using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    private float timeAttack;
    public float startAttack;

    public Transform attackPos;
    public LayerMask Enemies;
    public Animator camAnim;
    public Animator playerAnim;
    public float attackRange;
    public int damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(timeAttack <= 0)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, Enemies);
                for(int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<Enemy>().health -= damage;
                }
            }
            timeAttack = startAttack;
        } else
        {
            timeAttack -= Time.deltaTime;
        }
	}

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }

    

}
