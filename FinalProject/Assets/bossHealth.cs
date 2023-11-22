using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossHealth : MonoBehaviour
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
        int coinChance = Random.Range(0,3);
        int healthChance = Random.Range(0,7);
        if(health <= 0){
            Destroy(this.gameObject);
            

        }
   }
   public bool isAlive(){
    if(health > 0){
        return true;
    }

    return false;
   }
   
}
