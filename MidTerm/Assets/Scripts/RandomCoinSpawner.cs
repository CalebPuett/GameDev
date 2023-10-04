using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCoinSpawner : MonoBehaviour
{
    [SerializeField] GameObject [] myObjects;

    
    // Start is called before the first frame update
    void Start()
    {
        SpawnCoinsandSquaresOverTime();
    }

    void SpawnCoinsandSquaresOverTime(){
        StartCoroutine(SpawnCoinsandSquaresOverTimeRoutine());

        IEnumerator SpawnCoinsandSquaresOverTimeRoutine(){
           while(true){
           yield return new WaitForSecondsRealtime(.3f);
           int ranIndex = Random.Range(0,myObjects.Length);
            GameObject newObject = Instantiate(myObjects[ranIndex],new Vector3(Random.Range(-5,4),6,0),Quaternion.identity);
            Destroy(newObject,10);
            
            }
        }
   
    }
}
