using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class move : MonoBehaviour
{

    [SerializeField] float speed = 5;
    [SerializeField] Transform[] Waypoints;
    Rigidbody2D rb;
    private int wayPointsIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    
       Move();
    }
    public void Move(){
        
        if(wayPointsIndex <= Waypoints.Length -1 ){
            transform.position = Vector2.MoveTowards(transform.position , Waypoints[wayPointsIndex].transform.position, speed*Time.deltaTime);


            if(transform.position == Waypoints[wayPointsIndex].transform.position){
                wayPointsIndex += 1;
            }
        }
        }
}
