using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeWeapons : MonoBehaviour
{
   public DestroyBullet dps;

   void Awake()
   {
    dps.damage = 1;
   }
   public void UpgradeWeapon(){
        dps.damage++;
        
   }

  
}
