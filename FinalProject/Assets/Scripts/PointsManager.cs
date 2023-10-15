using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointsManager : MonoBehaviour
{
     public static PointsManager instance;

    // Start is called before the first frame update
    [SerializeField] Text scoreText;
    int score = 0;
    public void Awake(){
        instance = this;
    }
    void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    public void AddPoint(){
        score += 1;
        scoreText.text = score.ToString();
    }
}
