using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using DG.Tweening;
using UnityEngine;

public class BallAnimation : MonoBehaviour
{

    [SerializeField]
    private float lifeTime;
    [SerializeField]
    private float size;

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
                Debug.Log(Score.GetScore());
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
        Debug.Log(Score.GetScore());
    }

    
}
