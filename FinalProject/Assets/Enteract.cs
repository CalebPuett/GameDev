using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enteract : MonoBehaviour
{
    [SerializeField] Text pressE;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        
            pressE.text = "Press E to interact";
        }
    private void OnTriggerExit2D(Collider2D collision)
    {
        pressE.text = "";
    }
}

