using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Unlock : MonoBehaviour
{
   [SerializeField] PointsManager enemyCount;
    [SerializeField] GameObject bossFight;
    [SerializeField] GameObject loc;

   void Update()
   {
    if(enemyCount.checkRoundEnd()){
      loc.SetActive(false);
      bossFight.SetActive(true);
    }
    else{
      loc.SetActive(true);
      bossFight.SetActive(false);
    }
   
   }
}
