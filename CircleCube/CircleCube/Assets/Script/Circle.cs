using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Circle : Shapes, IPointerClickHandler
{
  
    public void OnPointerClick(PointerEventData eventData)
    {
        _panel.SecondShape(this.gameObject,scale);
        
    }
}
