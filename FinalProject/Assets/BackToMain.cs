using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackToMain : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
   {
    if(other.gameObject.tag == "HitBox"){
        SceneManager.LoadScene("Level1");
    }
   }
}
