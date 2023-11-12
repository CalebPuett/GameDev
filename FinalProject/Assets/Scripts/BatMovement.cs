using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatMovement : MonoBehaviour
{
     [SerializeField] float speed = 5;
    
    [SerializeField] Transform body;
    Rigidbody2D rb;
    //float frozenTime = 0f;
    //float resumeTime = 4f;
    
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
    public void stop(){
        MoveRb(Vector3.zero);
    }
    public void ice(){
        float regSpeed = speed;
        StartCoroutine(SlowDown());
        //speed = regSpeed;
        IEnumerator SlowDown(){
            speed = speed/2;
            yield return new WaitForSeconds(4);
            speed = regSpeed;
            yield return null;
        }
        
    }
}
