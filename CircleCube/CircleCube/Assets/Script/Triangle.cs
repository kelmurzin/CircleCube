﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Triangle : Shapes, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        _panel.ThirdShape(this.gameObject);
        
    }
}
