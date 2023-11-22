using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionSpawner : MonoBehaviour
{
   [SerializeField] GameObject spiderPrefab;
   [SerializeField] Transform bossTransform;
   bossHealth health;

    void  Start()
    {
        health = GetComponent<bossHealth>();
        StartSpawn();
        
    }

    public void StartSpawn(){
        StartCoroutine(SpawnMinions());
    IEnumerator SpawnMinions()
{
    while(health.isAlive()){
        yield return new WaitForSeconds(2);
        Instantiate(spiderPrefab,bossTransform.position,Quaternion.identity);
    }
    yield return null;
     }
    }
}
