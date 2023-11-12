using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileThrower : MonoBehaviour
{
  
  public Transform gun;
  [SerializeField] float speed = 10f;
  public void Throw(Vector3 targetPosition,GameObject projectilePrefab){
            

   Rigidbody2D newRB = Instantiate(projectilePrefab,gun.position,Quaternion.identity).GetComponent<Rigidbody2D>();
  
   targetPosition.z = 0;
   newRB.velocity = (targetPosition - gun.position).normalized * speed;
  
  }
}
