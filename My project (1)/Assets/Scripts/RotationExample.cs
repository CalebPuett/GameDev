using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationExample : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    void Start()
    {
      //transform.eulerAngles = new Vector3(0,0,45);
      //transform.Rotate(new Vector3(0,0,45));

      //transform.rotation = Quaternion.LookRotation(transform.forward,target.position - transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(0,0,45)  * Time.deltaTime);
        //mousePosistion stuff
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        Quaternion lookRotation = Quaternion.LookRotation(transform.forward,mousePos - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation,lookRotation,Time.deltaTime *10);
    }
}
