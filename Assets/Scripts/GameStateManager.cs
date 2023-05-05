using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Exited Successfully.");
    }

    public string sceneName;

    public void GoToScene()
    {
        SceneManager.LoadScene(sceneName);
    }

}
