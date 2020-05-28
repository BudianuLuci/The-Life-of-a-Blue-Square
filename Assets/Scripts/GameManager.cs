
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f; //1f

    public GameObject completeLevelUI;
    public GameObject YouDiedUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Debug.Log(SceneManager.GetActiveScene().name);
    }

    public void EndGame()
    {
        YouDiedUI.SetActive(true);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        YouDiedUI.SetActive(false);

    }

}