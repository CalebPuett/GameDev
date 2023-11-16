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
    public Button ehBoost;
    public Button aBoost;
    public int speedBoostAmount = 10;
    [SerializeField] GameObject speelsPage;
    [SerializeField] GameObject speelsBoost;
    public Button weaponButton;
    public bool weaponClicked = false;
    public bool speelsClicked = false;
    public Button speelsButton;
    public GameObject playerHealthUi;
    [SerializeField] GameObject boostUi;
    [SerializeField] Button backButton;
    public UpgradeSystem upgradeSystem;
    // Update is called once per frame
  
    void Update()
    {   
      
       if(upgradeSystem.SbAmmount == 40){
        speedBoost.interactable = false;

       }
       if(upgradeSystem.EhAmount == 40){
        ehBoost.interactable = false;
       }
       if(upgradeSystem.ssAmount == 40){
        aBoost.interactable = false;
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
        speelsBoost.SetActive(false);
        speelsPage.SetActive(false);
        
    }
   public void isweaponClicked(){
    weaponClicked = true;
    boostUi.SetActive(false);
    speelsPage.SetActive(false);
    backButton.gameObject.SetActive(true);
    speelsBoost.SetActive(true);
   }
   public void isSpellesClicked(){
        speelsClicked = true;
        speelsBoost.SetActive(false);
        boostUi.SetActive(false);
        backButton.gameObject.SetActive(true);
        speelsPage.SetActive(true);

   }
   public void backButtonClicked(){
        weaponClicked = false;
        speelsClicked = false;
         boostUi.SetActive(true);
         backButton.gameObject.SetActive(false);
         speelsPage.SetActive(false);
         speelsBoost.SetActive(false);
   }
}
