using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpgradeButtons : MonoBehaviour
{
   

   
    public Image Sb;
    public Text sbAmount;
    public Text ehAmount;
    public Text aAmount;
    public Image secSb;
    public Image thSb;
     public Image Eh;
    public Image secEh;
    public Image thEh;
    public Image A;
    public Image secA;
    public Image thA;
    
    private bool sbClick;
    private bool ehClick;
    private bool aClick;
    public PLayerInfoSo coinsSo;
    public UpgradeSystem ammounts;
    [SerializeField] Text notEnough;
    
    [SerializeField] Text scoreText;
    
    void Start()
    {
        notEnough.enabled = false;
        sbAmount.text = ammounts.SbAmmount.ToString();
        ehAmount.text = ammounts.EhAmount.ToString();
        aAmount.text = ammounts.ssAmount.ToString();
        if(ammounts.SbAmmount == 20){
            Sb.color = Color.red;
        }
        if(ammounts.SbAmmount == 30){
            secSb.color = Color.red;
            Sb.color = Color.red;
        }
        if(ammounts.SbAmmount == 40){
            thSb.color = Color.red;
             secSb.color = Color.red;
            Sb.color = Color.red;
        }
        if(ammounts.EhAmount == 20){
            Eh.color = Color.red;
        }
        if(ammounts.EhAmount == 30){
            secEh.color = Color.red;
            Eh.color = Color.red;
        }
         if(ammounts.EhAmount == 40){
            thEh.color = Color.red;
            secEh.color = Color.red;
            Eh.color = Color.red;
        }
        if(ammounts.ssAmount == 20){
            A.color = Color.red;
        }
      if(ammounts.ssAmount == 30){
            secA.color = Color.red;
            A.color = Color.red;
        }
       if(ammounts.ssAmount == 40){
            thA.color = Color.red;
            secA.color = Color.red;
            A.color = Color.red;
        }
    }
    void Update()
    {
        scoreText.text = coinsSo.coins.ToString();
    }
    public void purchase(){
        if(sbClick){
            if(ammounts.SbAmmount <= coinsSo.coins){
                coinsSo.coins = coinsSo.coins - ammounts.SbAmmount;
                SBfillBox();
                notEnough.enabled = false;
                sbClick = false;
                ammounts.SbAmmount += 10;
                sbAmount.text = ammounts.SbAmmount.ToString();

        }
        else{
           notEnough.enabled = true;
        } 
        }
        if(ehClick){
            if(ammounts.EhAmount <= coinsSo.coins){
                coinsSo.coins = coinsSo.coins - ammounts.EhAmount;
                EhfillBox();
                ehClick = false;
                notEnough.enabled = false;
                ammounts.EhAmount +=10;
                ehAmount.text = ammounts.EhAmount.ToString();
            }
             else{
                notEnough.enabled = true;
             }
        }
        
            if(aClick){
                if(ammounts.ssAmount <= coinsSo.coins){
                    coinsSo.coins = coinsSo.coins - ammounts.ssAmount;
                    AfillBox();
                    aClick = false;
                    notEnough.enabled = false;
                    ammounts.ssAmount += 10;
                    aAmount.text = ammounts.ssAmount.ToString();
                    coinsSo.spellSpeed+=1;
           }
           else{
             notEnough.enabled = true;
        }
       
        
        }     

          
        
     
    }
    public void SbClicked(){
        sbClick = true;
    }
    public void EhClicked(){
        ehClick = true;
    }
    public void aClicked(){
        aClick = true;
    }
     public void SBfillBox(){
        if(Sb.color != Color.red){
            Sb.color = Color.red;
        }
        else if(Sb.color == Color.red && secSb.color == Color.white){
            secSb.color = Color.red;
        }
        else if(secSb.color == Color.red){
            thSb.color = Color.red;
        }
    }
    public void EhfillBox(){
        if(Eh.color != Color.red){
            Eh.color = Color.red;
        }
        else if(Eh.color == Color.red && secEh.color == Color.white){
            secEh.color = Color.red;
        }
        else if(secEh.color == Color.red){
            thEh.color = Color.red;
        }
    }
    public void AfillBox(){
        if(A.color != Color.red){
            A.color = Color.red;
        }
        else if(A.color == Color.red && secA.color == Color.white){
            secA.color = Color.red;
        }
        else if(secA.color == Color.red){
            thA.color = Color.red;
        }
    }
}
