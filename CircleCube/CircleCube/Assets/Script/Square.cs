using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Square : Shapes, IPointerClickHandler
{
    private float scaleSprite = 0.7f;

    [SerializeField] private SpriteRenderer _sprite;
    

    public void OnPointerClick(PointerEventData eventData)
    {
        _panel.FirstShape(this.gameObject,scale);
    }

    protected override void Start()
    {
        base.Start();
        _sprite.transform.localScale = new Vector2(scaleSprite, scaleSprite);
                
    }
    
}
