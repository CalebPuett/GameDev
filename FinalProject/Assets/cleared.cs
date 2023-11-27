using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleared : MonoBehaviour
{
    public Unlock unlcok;
    
    void Start()
    {
        unlcok = GetComponent<Unlock>();
    }

    // Update is called once per frame
    void Update()
    {
        unlcok.Invoke("active",1f);
        this.gameObject.SetActive(true);
    }
}
