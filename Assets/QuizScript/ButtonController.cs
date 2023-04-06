using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void RetryGame (){
        SceneManager.LoadScene("SelectStages");
    }
    
    public void NextStage (){
        SceneManager.LoadScene("SelectStages");
    }

    public void MainMenu (){
        SceneManager.LoadScene("StartMenu");
    }
    
    public void QuitGame (){
        Application.Quit();     
    }
   public void OpenDoor (){
        SceneManager.LoadScene("Pass-Quiz 1");
    }
    public void FailDoor (){
        SceneManager.LoadScene("JumpScare");
    }
}
