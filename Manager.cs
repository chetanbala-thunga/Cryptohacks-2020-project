using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float delay = 1f;

    public GameObject CompleteLevelUI;
    
    public void CompleteLevel ()
	{
		CompleteLevelUI.SetActive(true);
	}
    
    
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", delay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
