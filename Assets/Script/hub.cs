using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;

public class hub : MonoBehaviour
{
    public static int score = 0;

    public TMP_Text scoreText;
    public TMP_Text healthText;
    public TMP_Text manaText;
    public TMP_Text levelText;

    public Image healtImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }
}
