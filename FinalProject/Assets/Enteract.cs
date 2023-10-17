using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enteract : MonoBehaviour
{
    [SerializeField] Text pressE;
    [SerializeField] UpgradeMenu upgradeUI;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player"){
        
            pressE.text = "Press E to interact";
            upgradeUI.isColl = true;
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        pressE.text = "";
        upgradeUI.isColl = false;

    }
}

