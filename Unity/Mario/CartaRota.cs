using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class CartaRota : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    // tart is called before the first frame update
    public void OnDrag(PointerEventData eventData )
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        Debug.Log("Ondrag");
    }

    public void OnPointerDown (PointerEventData eventData) 
    {
       
        
            Debug.Log("OnPointerDown");
        
    }
    
    public void OnBeginDrag(PointerEventData eventData) 
    {
         
        Debug.Log("OnBeginDrag");
        canvasGroup.alpha = 6f;
        canvasGroup.blocksRaycasts = false;
    }
    
    public void OnEndDrag(PointerEventData eventData) 
    {
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }
    public void OnDrop(PointerEventData eventData)
    {

    }

}
 