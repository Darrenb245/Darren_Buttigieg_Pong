using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int num;
    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;

    public GUISkin layout;

    GameObject theBall;

    // Use this for initialization
    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball");
    }

    public static void Scores(string wallID)
    {
        Debug.Log(PlayerScore2);
        if (wallID == "RightWall")
        {
            PlayerScore1++;
            
        }
        else
        {

            
            PlayerScore2++;
        }

        if (PlayerScore1 == 3) ;


        else if (PlayerScore2 == 3) ;
        


    }


    [SerializeField]
    Balls gameball;
    private void GameOver(int Winner)
    {
     
        
        PlayerScore1 = 0;
        PlayerScore2 = 0;
        gameball.Reset();
    }

    void OnGUI()
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + PlayerScore1);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + PlayerScore2);

       

    }
}
    
