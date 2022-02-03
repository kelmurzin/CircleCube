using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Level;
public class Shapes : MonoBehaviour
{
    public int scale;

    protected ControlShape _panel;
    private LevelGame _lvlGame;

    protected virtual void Start()
    {
        _panel = FindObjectOfType<ControlShape>();
        _lvlGame = FindObjectOfType<LevelGame>();
        _lvlGame.LevelNext.AddListener(DestroyShape);
        this.transform.localScale = new Vector2(scale, scale);
        
    }

    private void DestroyShape()
    {
        Destroy(gameObject);
    }
}
