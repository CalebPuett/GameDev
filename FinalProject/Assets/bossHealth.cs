using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossHealth : MonoBehaviour
{
    public int health = 5;
    public int maxHealth = 5;
    int coins = 0;
    [SerializeField] GameObject coinPrefab;
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
            while(coins < 30){
            Instantiate(coinPrefab,new Vector3(Random.Range(-9,23),5,0),Quaternion.identity);
            coins++;
            }

        }
   }
   public int getHealth(){
    return health;
   }
   public bool isAlive(){
    if(health > 0){
        return true;
    }

    return false;
   }
   
}
