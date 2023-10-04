using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBoxSpawner : MonoBehaviour
{
   [SerializeField] GameObject SquarePrefab;
    // Start is called before the first frame update
    void Start()
    {
        SpawnSquareOverTime();
    }

    void SpawnSquareOverTime(){
        StartCoroutine(SpawnSquareOverTimeRoutine());

        IEnumerator SpawnSquareOverTimeRoutine(){
           while(true){
            yield return new WaitForSeconds(1);
            GameObject newCoin = Instantiate(SquarePrefab,new Vector3(Random.Range(-5,4),4.8f,0),Quaternion.identity);
            Destroy(newCoin,10);

           
            }
        }
   
    }
}
