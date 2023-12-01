using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextRound : MonoBehaviour
{   
  
    
    [SerializeField] GameObject round1Spanwers;
    [SerializeField] GameObject unlock;
     public GameObject spawn1;
  
   void OnCollisionEnter2D(Collision2D other)
   {
    if(other.gameObject.tag == "Player"){
        spawn1.GetComponent<Spawner>().nextRound();
        
       
       
    }
   
}
}
