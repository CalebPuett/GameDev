using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openChest : MonoBehaviour
{
    [SerializeField] GameObject coinPrefab;
    [SerializeField] SpawnPoint coinSpawn;
    
    public bool isCol;
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.gameObject.tag == "Player"){
          coinSpawn.isCol = true;
        }
 
    } 
    void OnTriggerExit2D(Collider2D other)
    {
        coinSpawn.isCol = false;
    }
}
