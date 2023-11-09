using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    Movement movement;
    public Rigidbody2D rb;
    ProjectileThrower projectileThrower;
    Vector2 mousePos;
    public Camera cam;
    
    void  Awake()
    {
        movement = GetComponent<Movement>();
        projectileThrower = GetComponent<ProjectileThrower>();
    }

    void  FixedUpdate()
    {
        
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 vel = Vector3.zero;
        if(Input.GetKey(KeyCode.D)){
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
    void Update()
    {
    
    //projectile 
    if(Input.GetMouseButtonDown(0)){
     projectileThrower.Throw(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
}
}
