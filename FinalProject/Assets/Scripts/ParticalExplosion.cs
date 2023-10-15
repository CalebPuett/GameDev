using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalExplosion : MonoBehaviour
{
    public ParticleSystem BarrleSystem;
   

    public void explode()
    {
            GetComponentInChildren<SpriteRenderer>().color = Color.clear;
            BarrleSystem.Play();
            Destroy(this.gameObject,1);
        }
    }

