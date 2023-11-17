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
   public Text notEnough;
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
   public Button fSpellButton;
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
        if(usSo.fSpellCost == 20){
         f1.color = Color.red;
        }
        if(usSo.fSpellCost == 30){
         f2.color = Color.red;
         f1.color = Color.red;
        }
        if(usSo.fSpellCost == 40){
          f2.color = Color.red;
         f1.color = Color.red;
         f3.color = Color.red;
         fSpellButton.interactable = false;
        }
        if(usSo.vSpellCost == 20){
         v1.color = Color.red;
        }
        if(usSo.vSpellCost == 30){
         v2.color = Color.red;
         v1.color = Color.red;
        }
        if(usSo.vSpellCost == 40){
         v3.color = Color.red;
         v2.color = Color.red;
         v1.color = Color.red;
         vSpellButton.interactable = false;
        }
        if(usSo.iSpellCost == 20){
         i1.color = Color.red;
        }
        if(usSo.iSpellCost == 30){
         i2.color = Color.red;
         i1.color = Color.red;
        }
        if(usSo.iSpellCost == 40){
          i2.color = Color.red;
         i1.color = Color.red;
         i3.color = Color.red;
         iSpellButton.interactable = false;
        }
   }

  
   public void lightIncrease(){
   if(usSo.lSpellCost <= infoSo.coins){
      infoSo.lSpellDamage+=1;
      infoSo.coins = infoSo.coins - usSo.lSpellCost;
      usSo.lSpellCost += 10;
      }
   else{
      notEnough.enabled = true;
   }

   }
   public void voidIncrease(){
      if(usSo.vSpellCost <= infoSo.coins){
         infoSo.vSpellDamge +=1;
         infoSo.coins = infoSo.coins - usSo.vSpellCost;
         usSo.vSpellCost += 10;
      }
      else{
      notEnough.enabled = true;
   }
   }
   public void iceIncrease(){
      if(usSo.iSpellCost <= infoSo.coins){
         infoSo.iSpellDamage += 1;
         infoSo.coins = infoSo.coins - usSo.iSpellCost;
         usSo.iSpellCost += 10;
      }
      else{
      notEnough.enabled = true;
   }
   }
   public void fireIncrease(){
      if(usSo.fSpellCost <= infoSo.coins){
         infoSo.fSpellDamage +=1;
         infoSo.coins = infoSo.coins - usSo.fSpellCost;
         usSo.fSpellCost +=10;

      }
      else{
      notEnough.enabled = true;
   }
   }
}
