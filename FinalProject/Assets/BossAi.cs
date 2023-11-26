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
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    VenumShooter shoot;
    [SerializeField] MinionSpawner spawner;
    void  Awake()
    {
        movement = GetComponent<SpiderBossMovement>();
        player = GameObject.FindGameObjectWithTag("HitBox");
        playerHealth = player.GetComponent<PlayerHealth>();
        shoot = GetComponent<VenumShooter>();
        
    }
    void Start()
    {
        
    }
    void Update()
    {
        Quaternion lookRotation = Quaternion.LookRotation(transform.forward,transform.position - player.transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation,lookRotation,Time.deltaTime *10);
       
        if(Vector3.Distance(bossTransform.position,player.transform.position) - viewRaidus < 7){
         movement.MoveRb(Vector3.zero);
         if(Time.time >= nextAttackTime){
            shoot.Throw(player.transform.position);
            nextAttackTime = Time.time +1f /attackRate;
         }
        }
        else if(Vector3.Distance(bossTransform.position,player.transform.position) > viewRaidus){
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
