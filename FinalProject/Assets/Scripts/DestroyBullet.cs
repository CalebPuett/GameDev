using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
      public int damage = 1;
      public PLayerInfoSo infoSo;
      public GameObject icePrefab;
      public GameObject firePrefab;
      public GameObject voidPrefab;
      public GameObject lightningPrefab;

   void OnTriggerEnter2D(Collider2D other)
   {
      if(infoSo.activeSpell == icePrefab){
         damage = infoSo.iSpellDamage;
      }
      else if(infoSo.activeSpell == firePrefab){
         damage = infoSo.fSpellDamage;
      }
      else if(infoSo.activeSpell == voidPrefab){
         damage = infoSo.vSpellDamge;
          
      }
      else if(infoSo.activeSpell == lightningPrefab){
         damage = infoSo.lSpellDamage;
      }
      if(other.gameObject.tag == "Barrel"){
         other.gameObject.GetComponent<BarrelHealth>().TakeDamage(damage);
         Destroy(this.gameObject);
      }
      else if(other.gameObject.tag == "Bat"){
         other.gameObject.GetComponent<BatHealth>().TakeDamage(damage);
         Destroy(this.gameObject);
      }
      else if(other.gameObject.tag == "Skel"){
         other.gameObject.GetComponent<SkeletonHealth>().TakeDamage(damage);
         Destroy(this.gameObject);
      }
     else if(other.gameObject.tag != "Player"){
       Destroy(this.gameObject);
    }
      
   }
}
