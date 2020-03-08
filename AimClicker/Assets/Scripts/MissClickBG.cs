using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissClickBG : MonoBehaviour

{

    [SerializeField] private Text scoreText;
    private void OnMouseDown()
    {
        Score.ConcatScore(-3);
        
    }
}
