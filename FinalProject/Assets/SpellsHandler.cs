using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpellsHandler : MonoBehaviour
{
    public bool lClick = false;
    public bool vClick = false;
    public UpgradeSystem usSo;
    public bool iClick = false;
    public PLayerInfoSo coinsSo;
    public Text notEnough;
    public Button lSpell;
    public Button iSpell;
    public Button v;

    void Update()
    {
        if(usSo.LUnlock){
            lSpell.interactable = false;
        }
        if(usSo.vUnlock){
            v.interactable = false;
        }
        if(usSo.iUnlock){
            iSpell.interactable = false;
        }
    }
    public void lightning(){
        lClick = true;
    }
    public void vSpell(){
        vClick = true;
    }
    public void ice(){
        iClick = true;
    }
    public void purchase(){
        if(lClick){
            if(usSo.lSpellCost <= coinsSo.coins){
                coinsSo.coins = coinsSo.coins - usSo.lSpellCost;
                usSo.LUnlock = true;
            }
             else{
                notEnough.enabled = true;
             }
        }
        if(vClick){
            if(usSo.vSpellCost<= coinsSo.coins){
                coinsSo.coins = coinsSo.coins - usSo.vSpellCost;
                usSo.vUnlock = true;
        }
        else{
                notEnough.enabled = true;
             }
    }
        if(iClick){
            if(usSo.iSpellCost <= coinsSo.coins){
                coinsSo.coins = coinsSo.coins - usSo.iSpellCost;
                usSo.iUnlock = true;
                
            }
             else{
                notEnough.enabled = true;
             }
        }
}
}
