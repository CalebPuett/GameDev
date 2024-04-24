using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giraffeStart : MonoBehaviour
{
    
    private Vector2 mousePosition;
    public float moveSpeed = 0.1f;
    public bool col = false;
    bool stop = false;
    void Start()
    {
       
    }
    // Update is called once per frame
    void  Update()
    {   
            
            if(!col){
             stop = Place();
            }
            if(!stop){
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position,mousePosition,moveSpeed);
            }
            else{
                moveSpeed = 0f;
            } 
    }

    public bool Place(){
        
         if(Input.GetKeyDown(KeyCode.Mouse0)){
            
              return true;
            }
        return false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Path"){
            col = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        col = false;
    }
   
}
