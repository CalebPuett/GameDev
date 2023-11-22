using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class EnemyAi : MonoBehaviour
{

   

    public float speed = 200;
    private GameObject player;
    public float nextWayPointDistance = 3f;
    Path path;
    public int viewRadius = 1;
    int currentWayPoint = 0;
    bool reachedEndOfPath = false;
    Seeker seeker;
    Rigidbody2D rb;
    public Transform enemyBody;
    float regSpeed;
    // Start\ is called before the first frame update
    void Start()
    {
        float regSpeed = speed;
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("HitBox");
         if(Vector3.Distance(transform.position,player.transform.position) < viewRadius){
            InvokeRepeating("UpdatePath",0f,.5f);
         
        seeker.StartPath(rb.position,player.transform.position,onPathComplete);
         }   
    }
    void onPathComplete(Path p){
        if(!p.error){
            path = p;
            currentWayPoint = 0;
        }
    }
    void UpdatePath(){
    if(Vector3.Distance(transform.position,player.transform.position) < viewRadius){
        if(seeker.IsDone()){
        seeker.StartPath(rb.position,player.transform.position,onPathComplete);
            }
    }
    }
    // Update is called once per frame
     void FixedUpdate()
    {
        
    
    
        if(path == null){
            return;
        }
        if(currentWayPoint >= path.vectorPath.Count){
            reachedEndOfPath = true;
            return;
        }
        else{
            reachedEndOfPath = false;
        }

        Vector2 direction = ((Vector2)path.vectorPath[currentWayPoint] - rb.position).normalized;
        Vector2 force = direction * speed *Time.deltaTime;
        rb.AddForce(force);
        float distance = Vector2.Distance(rb.position,path.vectorPath[currentWayPoint]);

        if(distance < nextWayPointDistance){
            currentWayPoint++;
        }
        if(force.x >= 0.01f){
            enemyBody.localScale = new Vector3(-1f,1f,1f);
        }
        else if(force.x <= -0.01f){
            enemyBody.localScale = new Vector3(1f,1f,1f);
        }
    }
    public void ice(){
        regSpeed = speed;
        StartCoroutine(SlowDown());
        //speed = regSpeed;
        IEnumerator SlowDown(){
            if(speed != 200){
                speed = speed/2;
            }
            yield return new WaitForSeconds(2);
            speed = regSpeed;
            yield return null;
        }
        
    }
   
}
