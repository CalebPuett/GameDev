using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 1;
    Rigidbody2D rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start(){
        
    }
    public void MoveTransform(Vector3 velo){
        transform.position +=  velo * speed * Time.deltaTime;
        
    }
    public void MoveRb(Vector3 vel){
        rb.velocity = vel * speed;
    }
}