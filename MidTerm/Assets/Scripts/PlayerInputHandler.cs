using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
     Movement movement;
    
     void Awake(){
        movement = GetComponent<Movement>();
        
     }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   void FixedUpdate()
    {
        Vector3 vel = Vector3.zero;
        if (Input.GetKey(KeyCode.D)){
            vel.x = 1;
        }
        if(Input.GetKey(KeyCode.A)){
            vel.x = -1;
        }
        if(Input.GetKey(KeyCode.W)){
            vel.y = 1;
        }
        if(Input.GetKey(KeyCode.S)){
            vel.y = -1;
        }
        movement.MoveRb(vel);
        
       
    }
    // Update is called once per frame
    void Update()
    {
            
           // score.Coins();
            
    
    //projectile 
   
    }
}

