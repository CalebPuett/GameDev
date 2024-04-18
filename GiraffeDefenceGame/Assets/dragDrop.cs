using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragDrop : MonoBehaviour , IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler{

private RectTransform rectTransform;
[SerializeField] private Canvas canvas;
private CanvasGroup canvasGroup;
[SerializeField] RectTransform itemSlot;
void Awake()
{
    rectTransform = GetComponent<RectTransform>();
    canvasGroup = GetComponent<CanvasGroup>();
    itemSlot = GetComponent<RectTransform>();

}

void  Update()
{
    if(rectTransform.anchoredPosition != itemSlot.anchoredPosition){
        canvasGroup.interactable = false;
    }
}
public void OnPointerDown(PointerEventData eventData){
    
}
public void OnBeginDrag(PointerEventData eventData){
    canvasGroup.blocksRaycasts = false;
}
public void OnEndDrag(PointerEventData eventData){
    canvasGroup.blocksRaycasts = true;
}
public void OnDrag(PointerEventData eventData){

    rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
}


}

