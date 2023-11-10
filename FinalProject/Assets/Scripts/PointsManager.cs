using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointsManager : MonoBehaviour
{
  
    public static PointsManager instance;
    public PLayerInfoSo coinsSo;
    [SerializeField] Text notEnough;
   
    // Start is called before the first frame update
    [SerializeField] Text scoreText;
    
    public void Awake(){
        instance = this;
        notEnough.enabled = false;
    }
    void Update()
    {
        scoreText.text = coinsSo.coins.ToString();
        
    }

    public int getCoins(){

        return coinsSo.coins;
    }

    
    
  
}
