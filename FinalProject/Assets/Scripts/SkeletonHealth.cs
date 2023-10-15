using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonHealth : MonoBehaviour
{
    public int health = 0;
    public int maxHealth = 5;
    public GameObject coinPrefab;
    public GameObject smallHealthPackPrefab;
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
            if(coinChance == 0){
            GameObject newCoin = Instantiate(coinPrefab,this.gameObject.transform.position,Quaternion.identity);
            }
            else if(healthChance == 0){
                GameObject newHealth = Instantiate(smallHealthPackPrefab,this.gameObject.transform.position,Quaternion.identity);
            }
        }
   }
   
}

