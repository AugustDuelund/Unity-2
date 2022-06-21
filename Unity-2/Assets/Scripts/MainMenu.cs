using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Start game.
    public void StartGame()
    {
        SceneManager.LoadScene("LavaLevel");
    }

    public void LoadLavaLevel()
    {
        SceneManager.LoadScene("LavaLevel");
    }

    public void LoadMazeLevel()
    {
        SceneManager.LoadScene("MazeLevel");
    }

    public void LoadSquidLevel()
    {
        SceneManager.LoadScene("SquidLevel");
    }

    //Only works when its an application, doesnt work in editor stuff.
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
}
