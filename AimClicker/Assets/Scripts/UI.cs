using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameOverWindow _gameOverWindow;

    public void UpdateWindow(int hp)
    {
        /*Timer timer;
        if ()
        {
            _gameOverWindow.Show();
        }*/
    }

    public void ChangeScore(int score)
    {
        _scoreText.text = score.ToString();
        _gameOverWindow.SetScore(score);
    }
}
