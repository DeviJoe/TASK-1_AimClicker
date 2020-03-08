using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class IntParamEvent : UnityEvent<int>
{

}

public class GameBehaviour  : MonoBehaviour
{
    private int _score;
    [SerializeField]
    private IntParamEvent _changeScore;

    public void AddScore(int score)
    {
        _score += score;
        _changeScore?.Invoke(_score);
    }
}
