using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Unlock : MonoBehaviour
{
   [SerializeField] PointsManager enemyCount;
    [SerializeField] GameObject nextRound;
    [SerializeField] GameObject loc;
  [SerializeField] PLayerInfoSo playerinfo;
  [SerializeField] GameObject bossFight;
   void Update()
   {
    if(enemyCount.checkRoundEnd()){
      loc.SetActive(false);
      nextRound.SetActive(true);
      bossFight.SetActive(true);
    }
    else{
      loc.SetActive(true);
      nextRound.SetActive(false);
      bossFight.SetActive(false);
    }
   
   }
}
