using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Main_Menu_Buttens : MonoBehaviour
{
    // Start is called before the first frame update
    public string state = "";
    public void Clicktartbutten()
    {
        GameManager gm = GameManager.Instance;
        gm.startbutten();
    }

    public void ClickNewGamebutten()
    {
        GameManager.score = 0;
    }

    public void Clickquitbutten()
    {
        Application.Quit();
    }
}
