using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceDamage : MonoBehaviour
{
   [SerializeField] int damage;
   [SerializeField] PLayerInfoSo infoSo;
   void Update()
    {
        damage = infoSo.iSpellDamage;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
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
