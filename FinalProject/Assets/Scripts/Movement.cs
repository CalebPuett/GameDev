using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Movement : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] float speed = 5;
    [SerializeField] AnimationStateChanger animationStateChanger;
    [SerializeField] Transform body;
    Rigidbody2D rb;
    public PLayerInfoSo infoSo;
   [SerializeField] AudioClip clip;
   public 
   
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        speed = infoSo.speed;
        
    }
    void Start(){
        
    }
    public void MoveTransform(Vector3 velo){
        transform.position +=  velo * speed * Time.deltaTime;
        
    }
    public void MoveRb(Vector3 vel){
        rb.velocity = vel * speed;
       
        if(vel.magnitude > 0){
            animationStateChanger.ChangeAnimationState("Walking",speed/5);

            if(vel.x > 0){
                body.localScale = new Vector3(1,1,1);
            }
            else if (vel.x < 0){
                body.localScale = new Vector3(-1,1,1);
            }
            if(!audioSource.isPlaying){
                audioSource.Play();
            }
            
        }
        else{
            audioSource.Stop();
            animationStateChanger.ChangeAnimationState("Idle");
        }
      
    }
    public void MoveToward(Vector3 targetPosition){
        Vector3 direction = targetPosition - transform.position;
        direction = Vector3.Normalize(direction);
        MoveRb(direction);
    }
    public void SbUpgrade(){
        speed +=1;
        infoSo.speed +=1;
        infoSo.spellSpeed +=1;
    }

}