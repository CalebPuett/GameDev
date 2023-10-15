using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 0;
    public int maxHealth = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

   public void TakeDamage(int damageDealt){
        health -= damageDealt;
        if(health <= 0){
            Destroy(this.gameObject);
        }
   }
}