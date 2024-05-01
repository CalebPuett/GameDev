using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    

    public enum SpawnState {SPAWNING,WAITING,COUNTING};
    
    [System.Serializable]
    public class Wave{
    public GameObject crock;
    public Transform spawnLocation;
    public float rate;
    public int count;
    
    
    }
  
    public Wave[] waves;
   
    private int nextWave = 0;
    public float timeBetweenWaves = 5f;
    private float waveCountdown;
    public bool startNext = false;
    private float searchCountdown = 1f;
    private SpawnState state = SpawnState.COUNTING;
    void Start()
    {
        waveCountdown = 0f;
    }

    void  Update()
    {
        
        if(state == SpawnState.WAITING){
            if(!EnemyIsAlive()){
                waveCompleted();
            }
            else{
                return;
            }
        }
        if(waveCountdown <= 0){
            startNext = false;
            if(state != SpawnState.SPAWNING){
                StartCoroutine(SpawnWave(waves[nextWave]));
                
            }
        }
        else{
            waveCountdown -= Time.deltaTime;
        }
    }
    void waveCompleted(){
        Debug.Log("Wave Completed!");
        state = SpawnState.COUNTING;
        waveCountdown = timeBetweenWaves;
       
        nextWave = 0;
        
    }
    IEnumerator SpawnWave(Wave wave){
        state = SpawnState.SPAWNING;

        for(int i = 0; i < wave.count; i++){
            SpawnEnemy(wave.crock);
            
            yield return new WaitForSeconds(1f/wave.rate);
        }
        state = SpawnState.WAITING;

        yield break;
    }
    bool EnemyIsAlive(){
        searchCountdown -=Time.deltaTime;
        if(searchCountdown <= 0f){
            searchCountdown = 1f;
            if(GameObject.FindGameObjectsWithTag("crock").Length == 0){
                return false;
         }
        }
        return true;
    }
    void SpawnEnemy (GameObject crock){
       
        Instantiate (crock,this.transform.position,Quaternion.identity);
       
        
    }
    
    public void nextRound(){
        state = SpawnState.COUNTING;
        waveCountdown = 0;
        waves[nextWave].count = waves[nextWave].count *2;
    }
}
