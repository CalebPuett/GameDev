using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonDamage : MonoBehaviour
{
    public float damage = 1;
    //SkelMovement movement;
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    void Awake()
    {
      // movement = GetComponent<SkelMovement>();
    }
    
   void OnTriggerStay2D(Collider2D other)
    {   

      // movement.MoveRb(Vector3.zero);
       if(other.gameObject.tag == "Player"){
            if(Time.time >= nextAttackTime){
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
            nextAttackTime = Time.time +1f /attackRate;
            }
         }

       
    }
}
