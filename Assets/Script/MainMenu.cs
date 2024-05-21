using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public static MainMenu Instance { get; private set;}
    public string state = "";
    public void startbutten()
    {
        SceneManager.LoadScene("game_01");
        state = "Game";
    }

    public void quitbutten()
    {
        Application.Quit();
    }
}
