using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissClickBG : MonoBehaviour
{
    private void OnMouseDown()
    {
        Score.ConcatScore(-3);
    }
}
