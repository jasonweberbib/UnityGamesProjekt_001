using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set;}
    public GameObject pause;
    public GameObject PausMenuObject;
    public GameObject PlayMenuObject;

    /// <summary>
    /// MAIN MENU BUTTENS
    /// </summary>

    public string state = "Game";
    public string canvisState = "Gameplay";
    public static int score = 0;

    void Start()
    {
        PausMenuObject.SetActive(false);
    }

    public void startbutten()
    {
        SceneManager.LoadScene("game_01");
        state = "Game";
    }

    public void NewGamebutten()
    {

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

        





        /*
    if(Input.GetKeyDown(KeyCode.Escape)){
        if  (pause.activeSelft){
                pause.SetActive(false);
            }else{
                pause.SetActive(true);
            };
            //pause.SetActive(!pause.activeSelft);
    }
        */


    }


    public void KeyEscape()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvisState == "Gamaplay" && state == "Game")
            {
                Debug.Log("FUCK");
                PausMenuObject.SetActive(true);
                PlayMenuObject.SetActive(false);
                Time.timeScale = 0f;
                canvisState = "Pause";
            }
            else if (canvisState == "Pause" && state == "Game")
            {
                Debug.Log("FUCK1");
                PausMenuObject.SetActive(false);
                PlayMenuObject.SetActive(true);
                Time.timeScale = 1f;
                canvisState = "Gamaplay";
            }
        }
        */

        if (canvisState == "Gamaplay" && state == "Game")
        {
            Debug.Log("FUCK");
            PausMenuObject.SetActive(true);
            PlayMenuObject.SetActive(false);
            Time.timeScale = 0f;
            canvisState = "Pause";
        }
        else if (canvisState == "Pause" && state == "Game")
        {
            Debug.Log("FUCK1");
            PausMenuObject.SetActive(false);
            PlayMenuObject.SetActive(true);
            Time.timeScale = 1f;
            canvisState = "Gamaplay";
        }

    }

    private void leDestroy()
    {
        if(Instance == null)
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
