using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Score
{
    private static int _score;

    public static int GetScore()
    {
        return _score;
    }

    public static void ConcatScore(int val)
    {
        _score += val;
    }
    
}
