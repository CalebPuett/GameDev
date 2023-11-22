using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatDamage : MonoBehaviour
{
    public int damage = 1;
    //BatMovement movement;
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    private GameObject player;
    PlayerHealth playerHealth;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }
    
   void OnTriggerStay2D(Collider2D other)
    {   

      // movement.MoveRb(Vector3.zero);
       if(other.gameObject.tag == "HitBox"){
            if(Time.time >= nextAttackTime){
            playerHealth.TakeDamage(damage);
            nextAttackTime = Time.time +1f /attackRate;
            }
         }
         
    }
    
}

