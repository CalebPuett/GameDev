using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkelMovement : MonoBehaviour
{
     [SerializeField] float speed = 5;
    
    [SerializeField] Transform body;
    Rigidbody2D rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start(){
        
    }
    public void MoveTransform(Vector3 velo){
        transform.position +=  velo * speed * Time.deltaTime;
        
    }
    public void MoveRb(Vector3 vel){
        rb.velocity = vel * speed;
      
           //if(vel.x > 0){
          //     body.localScale = new Vector3(1,1,1);
           //}
           // else if (vel.x < 0){
           //     body.localScale = new Vector3(-1,1,1);
           // }
        }
       
        
    
    public void MoveToward(Vector3 targetPosition){
        
        Vector3 direction = targetPosition - transform.position;
        direction = Vector3.Normalize(direction);
        MoveRb(direction);
    }
}