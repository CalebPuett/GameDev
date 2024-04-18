using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getGiraffe : MonoBehaviour
{
    [SerializeField] GameObject giraffe;
    public void spawnGiraffe(){
        Rigidbody2D newRB = Instantiate(giraffe,(Camera.main.ScreenToWorldPoint(Input.mousePosition)),Quaternion.identity).GetComponent<Rigidbody2D>();
    }
}
