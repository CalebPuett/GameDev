using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float health = 0;
    public int maxHealth = 100;

    public HealthBar healthBar;
    public PLayerInfoSo info;
    // Start is called before the first frame update
    
    void Start()
    {

        health = info.health;
        maxHealth = info.maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

   public void TakeDamage(float damageDealt){
        
        health -= damageDealt;
        healthBar.SetHealth(health);
        if(health <= 0){
            SceneManager.LoadScene("MainMenu");
        }
   }
   public void AddHealth(float HealthAdded){
    
    if(health != maxHealth){
        health += HealthAdded;
        healthBar.SetHealth(health);
    }
   
   }
   public void increaseMaxHealth(){
    info.maxHealth +=10;
    maxHealth += 10; 
    healthBar.SetMaxHealth(maxHealth);
    healthBar.SetHealth(health);
   
   }
   
}
