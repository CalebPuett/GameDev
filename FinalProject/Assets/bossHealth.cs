using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossHealth : MonoBehaviour
{
    public int health = 5;
    public int maxHealth = 5;
    int coins = 0;
    public HealthBar healthBar;
    [SerializeField] GameObject coinPrefab;
    [SerializeField] GameObject spawner;
    [SerializeField] GameObject end;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(health);
    }

   public void TakeDamage(int damageDealt){
        health -= damageDealt;
        healthBar.SetHealth(health);
        int coinChance = Random.Range(0,3);
        int healthChance = Random.Range(0,7);
        
        if(health <= 0){
            Destroy(this.gameObject);
            spawner.SetActive(false);
            end.SetActive(true);
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
