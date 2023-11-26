using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenumShooter : MonoBehaviour
{ 
public Transform mouth;
[SerializeField] float speed = 10f;
  [SerializeField] GameObject VenumPrefabb;
  
  public void Throw(Vector3 targetPosition){
            
   
   Rigidbody2D newRB = Instantiate(VenumPrefabb,mouth.position,Quaternion.identity).GetComponent<Rigidbody2D>();
  
   targetPosition.z = 0;
   newRB.velocity = (targetPosition - mouth.position).normalized * speed;
  
  }

}
