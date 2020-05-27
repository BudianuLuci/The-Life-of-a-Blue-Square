
using UnityEngine;

public class TryAgainScript : MonoBehaviour
{
    public GameManager gameManager;
    public float restartDelay = 0.5f; //1f


    public void RestartGame()
    {
        gameManager.Invoke("Restart", restartDelay);
    }
}
