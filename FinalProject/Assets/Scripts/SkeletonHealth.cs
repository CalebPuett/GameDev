using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonHealth : MonoBehaviour
{
    public int health = 0;
    public int maxHealth = 5;
    public GameObject coinPrefab;
    public GameObject smallHealthPackPrefab;
     public PLayerInfoSo spell;
    private GameObject activeSpell;
    public GameObject icePrefab;
    public GameObject firPrefab;
    public GameObject voidPrefab;
    public GameObject lightningPrefab;
    public SkelMovement movement;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        activeSpell = spell.activeSpell;
        movement = GetComponent<SkelMovement>();
       
    }

   public void TakeDamage(int damageDealt){
        if(activeSpell == icePrefab){
            movement.ice();
        }
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

