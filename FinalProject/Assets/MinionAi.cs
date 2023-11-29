using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionAi : MonoBehaviour
{
    MinionMovement movement;
    public int damage =1;
    [SerializeField] float viewRaidus = 1;
    [SerializeField] Transform minionTransfrom;
    private GameObject player;
    PlayerHealth playerHealth;
    private GameObject playerHitBox;

    void  Awake()
    {
        movement = GetComponent<MinionMovement>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerHitBox = GameObject.FindGameObjectWithTag("HitBox");
        playerHealth = player.GetComponent<PlayerHealth>();
        
    }
    void Update()
    {
        if(Vector3.Distance(minionTransfrom.position,playerHitBox.transform.position) > viewRaidus){
            FollowPlayer();
        }
        else{
            playerHealth.TakeDamage(damage);
            movement.MoveRb(Vector3.zero);
            
           
        }
    }
    // Update is called once per frame

    public void FollowPlayer(){
        
        movement.MoveToward(playerHitBox.transform.position);
        
    }
}
