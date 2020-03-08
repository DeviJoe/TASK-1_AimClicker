using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class BallAnimation : MonoBehaviour
{

    [SerializeField]
    private float lifeTime;
    [SerializeField]
    private float size;

    [SerializeField] private Text scoreText;

    //Время создания объекта
    private float _startTime;
    //Время смерти объекта
    private float _endTime;
    private bool _isFirst = true;
    
    
    private void OnEnable()
    {
        transform.localScale = Vector3.zero;
    }

    private void Start()
    {
        _startTime = Time.time;
        DOTween.SetTweensCapacity(1300, 50);
    }
    
    private void Update()
    {
        try
        {
            if (transform.localScale.x < size - 0.05 && _isFirst)
            {
                transform.DOScale(new Vector3(size, size, 0), lifeTime);
            }
            else
            {
                _isFirst = false;
                transform.DOScale(new Vector3(0, 0, 0), lifeTime);
            }

            if (Math.Abs(transform.localScale.magnitude) < 0.05 && !_isFirst)
            {
                Destroy(gameObject);
                Score.ConcatScore(-5);
                
            }
        }
        catch (Exception e)
        {
            throw;
        }

    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Score.ConcatScore(10);
    }

    
}
