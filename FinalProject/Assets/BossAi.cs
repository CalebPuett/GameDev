using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAi : MonoBehaviour
{
    SpiderBossMovement movement;
    public int damage;
    [SerializeField] float viewRaidus = 1;
    [SerializeField] Transform bossTransform;
    private GameObject player;
    PlayerHealth playerHealth;
   

    void  Awake()
    {
        movement = GetComponent<SpiderBossMovement>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        
    }
    void Update()
    {
        if(Vector3.Distance(bossTransform.position,player.transform.position) > viewRaidus){
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
