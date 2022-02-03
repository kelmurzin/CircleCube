using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class ControlShape : MonoBehaviour
{
    private GameObject _square;
    private GameObject _circle;
    private GameObject _triangle;
    private int _scaleSquare;
    private int _scaleCircle;
    private EnergyText _energyText;
    [SerializeField] private UnityEvent _moveScore;

    public void FirstShape(GameObject square,int scale)
    {
        _square = square;
        _scaleSquare = scale;
        TriangleMove();
        
    }
    public void SecondShape(GameObject circle,int scale)
    {
        _circle = circle;
        _scaleCircle = scale;
        MoveShape();
    }

    public void ThirdShape(GameObject triangle)
    {
        _triangle = triangle;
        
    }

    private void TriangleMove()
    {
        if (_triangle != null)
        {
            if (_energyText.energyint > 0)
            {
                _triangle.transform.DOMove(_square.transform.position, .5f);
                Destroy(_triangle, 1f);
                ReduceScale();
                _energyText.UpdateEnergy();
            }

        }
        
    }

    private void ReduceScale()
    {
        Square sq = _square.GetComponent<Square>();
        sq.scale--;
        sq.transform.localScale = new Vector2(sq.scale, sq.scale);
    }
    private void MoveShape()
    {
        if (_square != null)
        {

            if (_scaleSquare == _scaleCircle)
            {
                _moveScore?.Invoke();
                _square.transform.DOMove(_circle.transform.position, .5f);
                Destroy(_square, .5f);
                Destroy(_circle, .5f);
            }
           
        }
    }
    private void Start()
    {
        _energyText = FindObjectOfType<EnergyText>();
    }
}
