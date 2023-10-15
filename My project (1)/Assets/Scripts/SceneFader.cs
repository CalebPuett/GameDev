using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour
{
    [SerializeField] Image fadeImage;
    [SerializeField] Color fadeColor = Color.black;
    [SerializeField] float fadeTime = 1;
    bool fadingOut = false;
    public Animator transistion;
 
    // Start is called before the first frame update
    void Start()
    {
        FadeIn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FadeIn(){
        StartCoroutine(FadeInRoutine());
        IEnumerator FadeInRoutine(){
            float timer = 0f;
            while(timer  < fadeTime){
                fadeImage.color = new Color(fadeColor.r,fadeColor.g,fadeColor.b,1f-(timer/fadeTime));
                timer += Time.deltaTime;
                yield return null;

            }
            fadeImage.color = Color.clear;
            yield return null;
        }
    }
    public void fadeOut(string sceneName){
        if(fadingOut){
            return;
        }
            fadingOut = true;
            StartCoroutine(FadeOutRoutine());
            IEnumerator FadeOutRoutine(){
                transistion.SetTrigger("Start");
                yield return null;
                SceneManager.LoadScene(sceneName);
            
         }
        }
    }
