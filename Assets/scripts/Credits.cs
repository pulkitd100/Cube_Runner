using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void EndGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
    public void gamestart()
    {
        Debug.Log("game has begun");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
