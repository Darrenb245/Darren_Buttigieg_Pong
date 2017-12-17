using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int num;
    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;
    public static int levelscore1 = 0;
    public static int levelscore2 = 0;
    public GUISkin layout;

    GameObject theBall;

    // Use this for initialization
    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball");
    }

    public static void Scores(string wallID)
    {
        
        if (wallID == "RightWall")
        {
         
            PlayerScore1++;
            levelscore1++;
            
        }
        else
        {

            
            PlayerScore2++;
            levelscore2++;
        }
         
        if (levelscore1 == 3|| levelscore2 == 3)
        {
            
            levelscore1 = 0;
            levelscore2 = 0;
            int currentScene = SceneManager.GetActiveScene().buildIndex;
            if (currentScene == 3)
            {
                if (PlayerScore1 > PlayerScore2)
                {
                    SceneManager.LoadScene(currentScene + 1);
                }
                else
                {
                    SceneManager.LoadScene(currentScene + 2);
               }
            }
            else
            {
                SceneManager.LoadScene(currentScene + 1);
           }
     
        }
        


    }



    void OnGUI()
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + PlayerScore1);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + PlayerScore2);

       

    }
}
    
