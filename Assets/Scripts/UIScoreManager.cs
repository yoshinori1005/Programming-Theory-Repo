using UnityEngine;
using UnityEngine.UI;

public class UIScoreManager : ScoreManager
{
    [SerializeField] private Text scoreText;

    protected override void UpdateScoreDisplay()
    {
        if (scoreText != null)
        {
            scoreText.text = $"Score: {GetScore()}\nHigh Score: {GetHighScore()}";
        }
    }
}
