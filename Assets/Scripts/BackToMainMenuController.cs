using UnityEngine;

public class BackToMainMenuController : MonoBehaviour
{
    public void OnStartClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("StartScene");
    }
}   