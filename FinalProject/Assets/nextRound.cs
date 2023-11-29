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
     public GameObject spawn1;
     public GameObject spawn2;
     public GameObject spawn3;
     public GameObject spawn4;
   void OnCollisionEnter2D(Collision2D other)
   {
    if(other.gameObject.tag == "Player"){
        spawn1.GetComponent<Spawner>().nextRound();
        spawn2.GetComponent<Spawner>().nextRound();
        spawn3.GetComponent<Spawner>().nextRound();
        //spawn4.GetComponent<Spawner>().nextRound();
    }
       
    }
   
}
