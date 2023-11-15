using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    Movement movement;
    public GameObject fireBallPrefab;
    public GameObject lightningPrefab;
    public GameObject voidPrefab;
   
    public GameObject icePrefab;
    public PLayerInfoSo activeSpell;
    public Rigidbody2D rb;
    ProjectileThrower projectileThrower;
    public UpgradeSystem upgradeSo;
    Vector2 mousePos;
    public Camera cam;
    private float iceAttackSpeed = 2f;
    float iceNextAttackTime;
    private float fireAttackSpeed = 2f;
    float fireNextAttack;
    private float voidAttackSpeed = 2f;
    float voidNextAttack;
    private float lightningAttackSpeed = 2f;
    float lightningNextAttack;
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
    if(upgradeSo.LUnlock  && Input.GetKey(KeyCode.Alpha2)){
            activeSpell.activeSpell = lightningPrefab;
        }
        if(upgradeSo.vUnlock && Input.GetKey(KeyCode.Alpha3)){
            activeSpell.activeSpell = voidPrefab;
        }
        if(upgradeSo.iUnlock && Input.GetKey(KeyCode.Alpha4)){
            activeSpell.activeSpell = icePrefab;
        }
    //projectile 
    
    if(Input.GetMouseButtonDown(0)){
        if(activeSpell.activeSpell == fireBallPrefab){
            if(Time.time >= fireNextAttack){
                projectileThrower.Throw(Camera.main.ScreenToWorldPoint(Input.mousePosition),activeSpell.activeSpell);
                fireNextAttack = Time.time +1f /fireAttackSpeed;
            }
        }
        if(activeSpell.activeSpell == icePrefab){
            if(Time.time >= iceNextAttackTime){
                projectileThrower.Throw(Camera.main.ScreenToWorldPoint(Input.mousePosition),activeSpell.activeSpell);
                iceNextAttackTime = Time.time +1f /iceAttackSpeed;
            }
        }
        if(activeSpell.activeSpell == voidPrefab){
            if(Time.time >= voidNextAttack){
                    projectileThrower.Throw(Camera.main.ScreenToWorldPoint(Input.mousePosition),activeSpell.activeSpell);
                    voidNextAttack = Time.time +1f /voidAttackSpeed;
                }
    }
    if(activeSpell.activeSpell == lightningPrefab){
            if(Time.time >= lightningNextAttack){
                    projectileThrower.Throw(Camera.main.ScreenToWorldPoint(Input.mousePosition),activeSpell.activeSpell);
                    lightningNextAttack = Time.time +1f /lightningAttackSpeed;
                }
    }
}

    }
}
