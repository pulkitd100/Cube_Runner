using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded =false;
    public GameObject CompleteLevelUI;
    public void EndGame()
    {
        if(GameHasEnded==false)
        {
            GameHasEnded = true;
            Invoke("Restart", 2f);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }
}
