using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giraffeStart : MonoBehaviour
{
    
    private Vector2 mousePosition;
    public float moveSpeed = 0.1f;
    void Start()
    {
       
    }
    // Update is called once per frame
    void  Update()
    {
            bool stop = place();
            if(!stop){
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position,mousePosition,moveSpeed);
            }
            else{
                moveSpeed = 0;
                stop = true;
            }
           
    }

    public bool place(){
         if(Input.GetKeyDown(KeyCode.Mouse0)){
              return true;
            }
        return false;
    }
}
