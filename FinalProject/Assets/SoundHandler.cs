using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour
{
    AudioSource audioSource;
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
   public void playFootstep(AudioClip clip){
        audioSource.PlayOneShot(clip);
        
   }
   public void stopFootstep(){
    audioSource.Stop();
   }
   public void playProjectile(AudioClip clip){
    audioSource.PlayOneShot(clip);
   }
}
