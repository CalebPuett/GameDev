using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public enum SpawnState {SPAWNING,WAITING,COUNTING};
    
    [System.Serializable]
    public class Wave{
    public GameObject batPrefab;
    public GameObject skelPrefab;
    public Transform spawnLocation;
    public float rate;
    public int count;
    
    }
    [SerializeField] Wave[] waves;
    public Transform[] SpawnPoints;
    private int nextWave = 0;
    public float timeBetweenWaves = 5f;
    private float waveCountdown;
    private float searchCountdown = 1f;
    private SpawnState state = SpawnState.COUNTING;
    void Start()
    {
        waveCountdown = timeBetweenWaves;
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
        if(nextWave + 1 > waves.Length -1){
            nextWave = 0;
            Debug.Log("All Waves Complete! Looping");
        }
        else{
            nextWave++;
        }
    }
    IEnumerator SpawnWave(Wave wave){
        Debug.Log("Spawning Wave");
        state = SpawnState.SPAWNING;

        for(int i = 0; i < wave.count; i++){
            SpawnEnemy(wave.batPrefab, wave.skelPrefab);
            yield return new WaitForSeconds(1f/wave.rate);
        }
        state = SpawnState.WAITING;

        yield break;
    }
    bool EnemyIsAlive(){
        searchCountdown -=Time.deltaTime;
        if(searchCountdown <= 0f){
            searchCountdown = 1f;
            if(GameObject.FindGameObjectsWithTag("Bat").Length == 0 & GameObject.FindGameObjectsWithTag("Skel").Length == 0){
                return false;
         }
        }
        return true;
    }
    void SpawnEnemy (GameObject bat, GameObject skel){
       
        Transform sp = SpawnPoints[Random.Range(0,SpawnPoints.Length)];
        Instantiate (bat,sp.position,Quaternion.identity);
        Instantiate(skel,sp.position,Quaternion.identity);
    }
}
