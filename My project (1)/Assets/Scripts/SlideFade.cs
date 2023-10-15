using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SlideFade : MonoBehaviour
{
  [SerializeField] Transform outTransform;
  [SerializeField] Transform inTransform;
  [SerializeField] float slideTime = 1;
 void Start()
 {
    SlideOut();
 }
  public void SlideOut(){
    StartCoroutine(SlideOutRoutine());
    IEnumerator SlideOutRoutine(){
    float timer = 0;
    while(timer < slideTime){
        timer += Time.deltaTime;
        transform.position = Vector3.Lerp(inTransform.position,outTransform.position,timer/slideTime);
        yield return null;
    }
    yield return null;
  }
}

  public void SlideInOut(string sceneName){
     StartCoroutine(SlideInOutRoutine());
     IEnumerator SlideInOutRoutine(){
    float timer = 0;
    while(timer < slideTime){
        timer += Time.deltaTime;
        transform.position = Vector3.Lerp(outTransform.position,inTransform.position,timer/slideTime);
      
        yield return null;
    }
      yield return new WaitForSeconds(.1f);
      SceneManager.LoadScene(sceneName);
    yield return null;
  }
  }
}
