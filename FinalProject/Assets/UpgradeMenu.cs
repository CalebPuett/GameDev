using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpgradeMenu : MonoBehaviour
{
    public static bool IsGameRunning = false;
    public static bool isKeyPressed = false;
    public bool isColl = false;
    public GameObject upgradeUI;
    public Button weaponButton;
    public bool weaponClicked = false;
    // Update is called once per frame
    void Update()
    {   
        if(weaponClicked){
        weaponButton.interactable = false;
        }
        CheckKey();
       if(isKeyPressed & isColl){
        upgradeUI.SetActive(true);
        Time.timeScale = 0f;
       }
       else{
        isKeyPressed = false;
        weaponClicked = false;
        weaponButton.interactable = true;
       }
       
    }
    public bool CheckKey(){
        if(Input.GetKey(KeyCode.E)){
            isKeyPressed = true;
        }
        return isKeyPressed;
    }
    public bool IsCollisoin(bool check){
        isColl = check;
        return isColl;
    }
    public void Resume(){
        upgradeUI.SetActive(false);
        Time.timeScale = 1f;
        isKeyPressed = false;
        
    }
   public void isweaponClicked(){
    weaponClicked = true;
    
   }
}
