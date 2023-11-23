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
    [SerializeField] GameObject unlockUpgrade;
    // Start is called before the first frame update
    [SerializeField] Text scoreText;
    
    public void Awake(){
        instance = this;
        unlockUpgrade.SetActive(true);
        if(notEnough != null){
        notEnough.enabled = false;
        }
    }
    void Update()
    {
        scoreText.text = coinsSo.coins.ToString();
        Invoke("getECount",1f);
    }

    public int getCoins(){

        return coinsSo.coins;
    }

    public void getECount(){
        count = GameObject.FindGameObjectsWithTag("Bat").Length + GameObject.FindGameObjectsWithTag("Skel").Length;
        eCount.text = count.ToString();
        if(count == 0){
            unlockUpgrade.SetActive(false);
        }
    }
    
  
}
