using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointsManager : MonoBehaviour
{
  
    public static PointsManager instance;
    public PLayerInfoSo coinsSo;
    
   
    public Text eCount;
    public int count;
    public static PointsManager singelton;
    // Start is called before the first frame update
    [SerializeField] Text scoreText;
    public static PointsManager singleton;
   void Awake()
   {
    if(singleton == null){
        singleton = this;
    }
    else{
        Destroy(this.gameObject);
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
        
    }
    public bool checkRoundEnd(){
        if(eCount.text == "0"){
            return true;
        }
        return false;
    }
  
}
