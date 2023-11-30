using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenumDamage : MonoBehaviour
{
    public int damge = 1;
    private GameObject player;
    public bool destroy = false;
     PlayerHealth playerHealth;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "HitBox"){
            playerHealth.TakeDamage(damge);
            this.gameObject.SetActive(false);
        }
       else if(other.gameObject.tag == "walls"){
        this.gameObject.SetActive(false);;
       }
    }
}
