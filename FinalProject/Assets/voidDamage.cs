using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voidDamage : MonoBehaviour
{

           public PLayerInfoSo infoSo;
            int tmplDamage;
            int tmpIDamage;
            int tmpfDamage;
           void  Start()
           { 
                int tmplDamage =  infoSo.lSpellDamage;
                int tmpIDamage = infoSo.iSpellDamage;
                int tmpfDamage = infoSo.fSpellDamage;
                StartCoroutine(damageBuff());
               
            
           }
            
            IEnumerator damageBuff(){
                infoSo.lSpellDamage *= 2;
                infoSo.iSpellDamage *= 2;
                infoSo.fSpellDamage *= 2;
                yield return new WaitForSeconds(4);
               
                yield return null;
            }
}
