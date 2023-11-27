using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextRound : MonoBehaviour
{   
    public bool round1Complete = false;
    public bool round2Complete = false;
    [SerializeField] GameObject round2Spanwers;
    [SerializeField] GameObject round1Spanwers;
    [SerializeField] GameObject unlock;
   void OnCollisionEnter2D(Collision2D other)
   {
    
        if(!round1Complete){
            this.gameObject.SetActive(false);
            round1Complete = true;
            round2Spanwers.SetActive(true);
            
        }
       
    }
   
}
