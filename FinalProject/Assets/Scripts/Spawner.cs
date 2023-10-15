using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject batPrefab;
    public int spwanLimit = 2;
    public int spwan;
    [SerializeField] Transform spawnLocation;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnSquareOverTime();
    }

    void SpawnSquareOverTime(){
        StartCoroutine(SpawnSquareOverTimeRoutine());

        IEnumerator SpawnSquareOverTimeRoutine(){
           while(spwan <= spwanLimit){
            spwan++;
            yield return new WaitForSeconds(1);
             Instantiate(batPrefab,spawnLocation.position,Quaternion.identity);
            
           
            }
        }
   
    }
 
}
