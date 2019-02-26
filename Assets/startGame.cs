using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
  public string levels;


  
 public void startScreen(){
    SceneManager.LoadScene ("Start");

    }

  public void startBtn(){
    SceneManager.LoadScene ("LevelScreen");

    }

   public void LeveloneLoad(){

   SceneManager.LoadScene ("Level1");
    }

   public void LeveloneReset(){

   SceneManager.LoadScene ("Level1");
    }
//----------------------------------------
    public void LevelTwoLoad(){

    SceneManager.LoadScene ("Level2");
    }

    public void LevelTwoReset(){

    SceneManager.LoadScene ("Level2");
    }
//--------------------------------------------


    public void LevelThreeLoad(){

    SceneManager.LoadScene ("Level3");
    }


    public void LevelThreeReset(){

    SceneManager.LoadScene ("Level3");
    }

 //-------------------------------------------

    
    public void LevelFourLoad(){

    SceneManager.LoadScene ("Level4");
    }


    public void LevelFourReset(){

    SceneManager.LoadScene ("Level4");
    }

    //---------------------------------------


    public void LevelFiveLoad(){

    SceneManager.LoadScene ("Level5");
    }


    public void LevelFiveReset(){

    SceneManager.LoadScene ("Level5");
    }

   //--------------------
    
    public void LevelSixLoad(){

    SceneManager.LoadScene ("Level6");
    }


    public void LevelSixReset(){

    SceneManager.LoadScene ("Level6");
    }



    
    }

