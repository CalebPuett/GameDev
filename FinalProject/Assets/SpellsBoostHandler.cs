using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpellsBoostHandler : MonoBehaviour
{
   public Button lighningButton;
    public PLayerInfoSo infoSo;



   public void lightIncrease(){
    infoSo.lSpellDamage+=1;
   }
}
