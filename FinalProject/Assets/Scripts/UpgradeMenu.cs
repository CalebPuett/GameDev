using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpgradeMenu : MonoBehaviour
{
    public bool speedClicked;
    public static bool IsGameRunning = false;
    public static bool isKeyPressed = false;
    public bool isColl = false;
    public GameObject upgradeUI;
    public Button speedBoost;
    public int speedBoostAmount = 10;
    public Button weaponButton;
    public bool weaponClicked = false;
    public bool speelsClicked = false;
    public Button speelsButton;
    public GameObject playerHealthUi;
    [SerializeField] GameObject boostUi;
    [SerializeField] Button backButton;
    // Update is called once per frame
    void Update()
    {   
      
       if(weaponClicked || speelsClicked ){
        boostUi.SetActive(false);
        backButton.gameObject.SetActive(true);
       }
        CheckKey();
       if(isKeyPressed & isColl){
        upgradeUI.SetActive(true);
        playerHealthUi.SetActive(false);
        Time.timeScale = 0f;
       }
       else{
        isKeyPressed = false;
        weaponClicked = false;
        speelsClicked = false;
        boostUi.SetActive(true);
        backButton.gameObject.SetActive(false);
        
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
        playerHealthUi.SetActive(true);
        upgradeUI.SetActive(false);
        Time.timeScale = 1f;
        isKeyPressed = false;
        
    }
   public void isweaponClicked(){
    weaponClicked = true;
   }
   public void isSpellesClicked(){
    speelsClicked = true;
   }
   public void backButtonClicked(){
        weaponClicked = false;
        speelsClicked = false;
         boostUi.SetActive(true);
         backButton.gameObject.SetActive(false);
         
   }
}
