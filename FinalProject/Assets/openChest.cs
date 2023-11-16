using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openChest : MonoBehaviour
{
    [SerializeField] GameObject coinPrefab;
    [SerializeField] GameObject Spawnpoint;
    public bool keyPressed;
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.gameObject.tag == "Player"){
           spawnCoin();
        }
    }
    public void checkKey(){
        if(Input.GetKeyDown(KeyCode.E)){
            keyPressed = true;
        }
    }
    void Update()
    {
        checkKey();
    }
    void spawnCoin(){
        if(keyPressed){
                GameObject newCoin = Instantiate(coinPrefab,Spawnpoint.transform.position,Quaternion.identity);
                keyPressed = false;
        }
    }
}
