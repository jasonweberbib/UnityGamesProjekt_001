using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void startbutten()
    {
        SceneManager.LoadScene("game_01");
    }

    public void quitbutten()
    {
        Application.Quit();
    }
}
