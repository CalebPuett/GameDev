using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAi : MonoBehaviour
{
    SkelMovement movement;
    public float damage;
    [SerializeField] float viewRadius = 1;
    [SerializeField] Transform SkelTransform;

    private GameObject player;
    PlayerHealth playerHealth;

    void  Awake()
    {
        movement = GetComponent<SkelMovement>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }
    void Update()
    {
        if(Vector3.Distance(transform.position,player.transform.position) < viewRadius){
            FollowPlayer();
        }
        else{
            Idle();
        }
    }

    public void FollowPlayer(){
        
        movement.MoveToward(player.transform.position);
    }

    
    
    public void Idle(){
        //do nothing
        movement.stop();
    }
}
