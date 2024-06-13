using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set;}

    /// <summary>
    /// MAIN MENU BUTTENS
    /// </summary>

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

    /// <summary>
    /// Back to Main Menu Timer
    /// </summary>
    /// 
    private float timer;
    private void Update()
    {
        timer =+ 1 * Time.deltaTime;
        if(state == "Game")
        {
            if (timer > 1200)
            {
                SceneManager.LoadScene("main_menu");
                state = "Menu";
                timer = 0;
            }
        }
        
    }

    private void leDestroy()
    {
        if(Instance != null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
