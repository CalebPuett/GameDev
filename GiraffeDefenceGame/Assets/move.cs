using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEditor.ShortcutManagement;
using UnityEngine;



public class move : MonoBehaviour
{

    [SerializeField] float speed = 5;
    [SerializeField] GameObject crock;
     
    
    GameObject[] Waypoints;
    Rigidbody2D rb;
    private int wayPointsIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    
        Waypoints = GameObject.FindGameObjectsWithTag("Points");
        
     
    }

    // Update is called once per frame
    void Update()
    {
        
       
        if(wayPointsIndex != Waypoints.Length){
            Move();
        }
      
    }
    public void Move(){
        
            
            crock.transform.position = Vector2.MoveTowards(crock.transform.position,Waypoints[wayPointsIndex].transform.position,speed*Time.deltaTime);

            if(crock.transform.position == Waypoints[wayPointsIndex].transform.position){
                
                wayPointsIndex += 1;
            }
            
        }

   
    }
        
