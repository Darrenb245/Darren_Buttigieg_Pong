﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;

    public GUISkin layout;

    GameObject theBall;

    // Use this for initialization
    void Start()
    {
        theBall = GameObject.FindObjectOfType<Balls>();
    }

    public static void Scores(string wallID)
    {
        if (wallID == "RightWall")
        {
            PlayerScore1++;
        }
        else
        {
            PlayerScore2++;
        }
    }

    void OnGUI()
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + PlayerScore1);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + PlayerScore2);


        if (PlayerScore1 == 5)
        {
          
        }
        else if (PlayerScore2 == 5)
        {

        }
    }
}
