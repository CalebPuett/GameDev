using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAi : MonoBehaviour
{
    SkelMovement movement;
    public float damage;
    [SerializeField] float viewRaidus = 1;
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
        if(Vector3.Distance(SkelTransform.position,player.transform.position) > viewRaidus){
            FollowPlayer();
        }
        else{
           playerHealth.TakeDamage(damage);
            movement.MoveRb(Vector3.zero);
        }
    }
    // Update is called once per frame

    public void FollowPlayer(){
        
        movement.MoveToward(player.transform.position);
        
    }
}
