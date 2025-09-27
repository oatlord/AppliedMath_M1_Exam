using UnityEngine;

public class StartMenuController : MonoBehaviour
{
    public void OnStartClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("AppliedMath_M1(Tarquini, Tamdang)");
    }
}