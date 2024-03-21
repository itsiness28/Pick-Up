using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dropearcarta : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData) 
    {
        Debug.Log("OnDrop");
    }
}
    // Start is called before the first frame update
    
