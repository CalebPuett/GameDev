using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    Movement movement;
    public GameObject fireBallPrefab;
    public GameObject lightningPrefab;
    public GameObject voidPrefab;
    private bool lUnlock = false;
    private bool vUnlock = false;
    private bool iUnlock = false;
    public GameObject icePrefab;
    public PLayerInfoSo activeSpell;
    public Rigidbody2D rb;
    ProjectileThrower projectileThrower;
    Vector2 mousePos;
    public Camera cam;
    
    void  Awake()
    {
        movement = GetComponent<Movement>();
        projectileThrower = GetComponent<ProjectileThrower>();
        activeSpell.activeSpell = fireBallPrefab;

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
    if(Input.GetKey(KeyCode.Alpha1)){
        activeSpell.activeSpell = fireBallPrefab;
    }
    if(lUnlock && Input.GetKey(KeyCode.Alpha2)){
            activeSpell.activeSpell = lightningPrefab;
        }
        if(vUnlock && Input.GetKey(KeyCode.Alpha3)){
            activeSpell.activeSpell = voidPrefab;
        }
        if(iUnlock && Input.GetKey(KeyCode.Alpha4)){
            activeSpell.activeSpell = icePrefab;
        }
    //projectile 
    if(Input.GetMouseButtonDown(0)){
     projectileThrower.Throw(Camera.main.ScreenToWorldPoint(Input.mousePosition),activeSpell.activeSpell);
    }
}
public void lActive(){
        lUnlock = true;
    }
public void vActive(){
    vUnlock = true;
}
public void iActive(){
    iUnlock = true;
}
}
