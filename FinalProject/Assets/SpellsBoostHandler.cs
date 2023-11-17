using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpellsBoostHandler : MonoBehaviour
{
   public Button lighningButton;
    public PLayerInfoSo infoSo;
   public Text lightAmmount;
   public Text fireAmmount;
   public Text voidAmmount;
   public Text iceAmmount;
   public Image l1;
   public Image l2;
   public Image l3;
   public Image v1;
   public Image v2;
   public Image v3;
   public Image f1;
   public Image f2;
   public Image f3;
   public Image i1;
   public Image i2;
   public Image i3;
   public UpgradeSystem usSo;
   public Button lSpellButton;
  
   public Button vSpellButton;
   public Button iSpellButton;
   void Start()
   {

        lightAmmount.text = usSo.lSpellCost.ToString();
        fireAmmount.text = usSo.fSpellCost.ToString();
        iceAmmount.text = usSo.iSpellCost.ToString();
        voidAmmount.text = usSo.vSpellCost.ToString();
        lSpellButton.interactable = false;
        vSpellButton.interactable = false;
        iSpellButton.interactable = false;

   }

   void Update()
   {
        if(usSo.LUnlock){
         lSpellButton.interactable = true;
        }
        if(usSo.vUnlock){
         vSpellButton.interactable = true;
        }
        if(usSo.iUnlock){
         iSpellButton.interactable = true;
        }
        lightAmmount.text = usSo.lSpellCost.ToString();
        fireAmmount.text = usSo.fSpellCost.ToString();
        iceAmmount.text = usSo.iSpellCost.ToString();
        voidAmmount.text = usSo.vSpellCost.ToString();
         if(usSo.lSpellCost == 20){
         l1.color = Color.red;
        }
        if(usSo.lSpellCost == 30){
         l2.color = Color.red;
         l1.color = Color.red;
        }
        if(usSo.lSpellCost == 40){
         l3.color = Color.red;
          l2.color = Color.red;
         l1.color = Color.red;
         lSpellButton.interactable = false;
        }
        
   }

  
   public void lightIncrease(){
   if(usSo.lSpellCost <= infoSo.coins){
      infoSo.lSpellDamage+=1;
      usSo.lSpellCost += 10;
      }

   }
}
