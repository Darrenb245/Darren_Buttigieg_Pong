using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour {
    private LevelManager myLevelManager;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "Balls")
        {
            string wallName = transform.name;
            Score.Scores(wallName);

            myLevelManager.LoadLevel("Level1");
            
        
        }
    }
}

