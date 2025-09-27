using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;

        if (score >= 10)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
