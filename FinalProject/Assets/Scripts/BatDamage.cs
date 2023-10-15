using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatDamage : MonoBehaviour
{
    public float damage = 1;
    BatMovement movement;
    void Awake()
    {
       movement = GetComponent<BatMovement>();
    }
    //void OnTriggerEnter2D(Collider2D other)
   // {
    //    if(other.gameObject.tag == "Player"){
            
     //       playerHealth.TakeDamage(damage);
     //   }
   // }
    void OnTriggerStay2D(Collider2D other)
    {   

       // movement.MoveRb(Vector3.zero);
        if(other.gameObject.tag == "Player"){
            
             other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
        }
    }
    
}
