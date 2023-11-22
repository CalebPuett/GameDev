using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionAi : MonoBehaviour
{
    MinionMovement movement;
    public int damage;
    [SerializeField] float viewRaidus = 1;
    [SerializeField] Transform minionTransfrom;
    private GameObject player;
    PlayerHealth playerHealth;
   

    void  Awake()
    {
        movement = GetComponent<MinionMovement>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        
    }
    void Update()
    {
        if(Vector3.Distance(minionTransfrom.position,player.transform.position) > viewRaidus){
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
