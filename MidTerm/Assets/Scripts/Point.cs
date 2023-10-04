using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Point : MonoBehaviour
{
 
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
       
       
      if(other.tag == "Player"){
        GetComponent<AudioSource>().Play();
       Destroy(this.gameObject,0.1f);
       PointsManager.instance.AddPoint();
      }
        
    }

  
}
