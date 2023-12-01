using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class Pickup : MonoBehaviour
{
    public PLayerInfoSo playerInfo;
    
    AudioSource audioSource;
    [SerializeField] AudioClip clip;
    
    public UnityEvent playSound;
    void OnTriggerEnter2D(Collider2D other)
    {
       // pickupEvent.Invoke();
        if(other.gameObject.tag == "Player"){
            GetComponent<AudioSource>().PlayOneShot(clip);
            Destroy(this.gameObject,.1f);
            playerInfo.coins += 1;
          
        }
    }
}
