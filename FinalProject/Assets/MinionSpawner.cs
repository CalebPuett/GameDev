using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionSpawner : MonoBehaviour
{
   [SerializeField] GameObject spiderPrefab;
   [SerializeField] Transform bossTransform;
   [SerializeField] bossHealth health;
    public int checkHealth;
    void  Start()
    {
        health = GetComponent<bossHealth>();
        checkHealth = health.getHealth();
        
    }

    public void StartSpawn(){
        StartCoroutine(SpawnMinions());
    }
    IEnumerator SpawnMinions()
{
    while(GameObject.FindGameObjectsWithTag("min").Length == 0){
        yield return new WaitForSeconds(10);
        Instantiate(spiderPrefab,bossTransform.position,Quaternion.identity);
        yield return null;
    }
    yield return null;
     }
}

