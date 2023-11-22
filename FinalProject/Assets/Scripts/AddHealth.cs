using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHealth : MonoBehaviour
{
    public int Health = 5;
  void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            other.gameObject.GetComponent<PlayerHealth>().AddHealth(Health);
            Destroy(this.gameObject);
        }
    }
}
