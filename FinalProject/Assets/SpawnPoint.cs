using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
 public bool isCol = false;
 public bool isKeyPressed = false;
[SerializeField] GameObject coinPrefab;
[SerializeField] GameObject chest;
[SerializeField] float radius = 5f;
[SerializeField] AnimationStateChanger animationStateChanger;
void Update()
{
    CheckKey();
   
    if(isCol && isKeyPressed){
        animationStateChanger.ChangeAnimationState("ChestOpen");
        Destroy(chest,1f);
        SpawnCoins();
    }
    isKeyPressed = false;
}
 public bool CheckKey(){
        if(Input.GetKey(KeyCode.E)){
            isKeyPressed = true;
        }
        return isKeyPressed;
    }
public void SpawnCoins(){
    isCol = false;
    isKeyPressed = false;
    int numCoins = Random.Range(1,10);
    for(int i = 0; i< numCoins;i++){
         float angle = i *Mathf.PI *2 /numCoins;
         float x = Mathf.Cos(angle) * radius;
         float z = Mathf.Sin(angle) * radius;
         Vector3 pos = transform.position + new Vector3(x,0,z);
         float angleDegress = -angle * Mathf.Rad2Deg;
         Quaternion rot = Quaternion.Euler(0,angleDegress, 0);
         Instantiate (coinPrefab,pos,Quaternion.identity);
    }
    
}
}
