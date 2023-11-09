using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatSimpleAi : MonoBehaviour
{
    // Start is called before the first frame update
    BatMovement movement;
    public float damage;
    [SerializeField] float viewRadius = 1;
    [SerializeField] Transform batTransform;
    
    private GameObject player;
    PlayerHealth playerHealth;
   

    void  Awake()
    {
        movement = GetComponent<BatMovement>();
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

