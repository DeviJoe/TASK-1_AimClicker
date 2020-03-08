using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    private float _startTime;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text totalText;
    [SerializeField] private GameObject gameObject;
    [SerializeField] private GameOverWindow _gameOverWindow;
    

    private void Awake()
    {
        _startTime = Time.time;
    }

    public float getTime()
    {
        return Time.time - _startTime;
    }

    private void Update()
    {
        scoreText.text = (Score.GetScore()).ToString();
        totalText.text = (Score.GetScore()).ToString();

        if (getTime() > 60)
        {
            Destroy(gameObject);
            _gameOverWindow.Show();
        }
    }
}
