using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpgradeButtons : MonoBehaviour
{
   

   
   
   
    
    public PLayerInfoSo coinsSo;
    [SerializeField] Text notEnough;
    
    [SerializeField] Text scoreText;
    
    void Start()
    {
        notEnough.enabled = false;

    }
    void Update()
    {
        scoreText.text = coinsSo.coins.ToString();
    }
    public void purchase(int ammount){
        if(ammount < coinsSo.coins){
            coinsSo.coins = coinsSo.coins - ammount;
        }
        else{
            notEnough.enabled = true;
            
           

            }
        
     
    }
   
}
