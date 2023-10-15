using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnRed : MonoBehaviour
{
   public void ChangeRed(){
    GetComponent<SpriteRenderer>().color = Color.red;
   }
}
