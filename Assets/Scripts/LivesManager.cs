using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivesManager : MonoBehaviour
{
    public TextMeshProUGUI livesText;
    public int lives = 3;

    void Start()
    {
        UpdateLivesText();
    }

    public void LoseLife()
    {
        lives--;
        UpdateLivesText();

        if (lives <= 0)
        {
            SceneManager.LoadScene("EndScene");
        }
    }

    private void UpdateLivesText()
    {
        livesText.text = "Lives: " + lives;
    }
}