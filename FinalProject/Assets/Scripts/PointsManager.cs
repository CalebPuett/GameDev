using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointsManager : MonoBehaviour
{
  
    public static PointsManager instance;
    public PLayerInfoSo coinsSo;
    [SerializeField] Text notEnough;
   
    public Text eCount;
    public int count;
    // Start is called before the first frame update
    [SerializeField] Text scoreText;
    
    public void Awake(){
        instance = this;
        notEnough.enabled = false;
    }
    void Update()
    {
        scoreText.text = coinsSo.coins.ToString();
        getECount();
    }

    public int getCoins(){

        return coinsSo.coins;
    }

    public void getECount(){
        count = GameObject.FindGameObjectsWithTag("Bat").Length + GameObject.FindGameObjectsWithTag("Skel").Length;
        eCount.text = count.ToString();
    }
    
  
}
