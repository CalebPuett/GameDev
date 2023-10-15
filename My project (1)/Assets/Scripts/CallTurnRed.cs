using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallTurnRed : MonoBehaviour
{
    [SerializeField] TurnRed turnRed;
    // Start is called before the first frame update
    void Start()
    {
        turnRed.ChangeRed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
