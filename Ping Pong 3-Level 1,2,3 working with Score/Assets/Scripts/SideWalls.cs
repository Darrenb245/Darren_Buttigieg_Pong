using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour {
    private LevelManager myLevelManager;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
         Debug.Log(hitInfo.name);
        if (hitInfo.name == "ball")
        {
            string wallName = transform.name;
            Console.Write(wallName); Score.Scores(wallName);
           

            myLevelManager.LoadLevel("Level1");
            
        
        }

   
    }
}

