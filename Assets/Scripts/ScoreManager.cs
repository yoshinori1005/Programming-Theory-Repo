using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score;
    private int highScore;

    public void AddScore(int points)
    {
        score += points;

        if (score > highScore)
        {
            highScore = score;
        }

        UpdateScoreDisplay();
    }

    public int GetScore() => score;
    public int GetHighScore() => highScore;

    protected virtual void UpdateScoreDisplay()
    {
        Debug.Log($"Score: {score}, High Score: {highScore}");
    }
}
