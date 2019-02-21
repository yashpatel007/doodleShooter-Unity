using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    public string levels;
    public void startBtn(){
    SceneManager.LoadScene ("Level");

    }

public void LevelReset(){

SceneManager.LoadScene ("Level");
 }

 public void LeveloneReset(){

SceneManager.LoadScene ("Level1");
 }

 public void LevelTwoReset(){

SceneManager.LoadScene ("Level2");
 }

//   public void LevelThreeReset(){

// SceneManager.LoadScene ("Level2");
//  }




    
    }

