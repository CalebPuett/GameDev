using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenumShooter : MonoBehaviour
{ 
public Transform mouth;
[SerializeField] float speed = 10f;
  [SerializeField] GameObject VenumPrefabb;
  List<Rigidbody2D> pool;
  void Start()
  {
    pool = new List<Rigidbody2D>();
  }
  public void Throw(Vector3 targetPosition){
            
   
   Rigidbody2D newRB;
   if(pool.Count > 10){
    pool.RemoveAt(0);
    pool[0].gameObject.SetActive(true);
    newRB = pool[0];
    newRB.position = mouth.position;
   }else{
    newRB = Instantiate(VenumPrefabb,mouth.position,Quaternion.identity).GetComponent<Rigidbody2D>();
   }
   
    pool.Add(newRB);
   targetPosition.z = 0;
   newRB.velocity = (targetPosition - mouth.position).normalized * speed;
  
  }

}
