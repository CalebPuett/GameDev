using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightningDamage : MonoBehaviour
{
    
    float liveTime = 1f;
    // Update is called once per frame
    void Start()
    {
        Destroy(gameObject,liveTime);
    }
}
