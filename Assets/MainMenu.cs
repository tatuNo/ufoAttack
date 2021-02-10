using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame (){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene(SceneManager.GetSceneByName("SampleScene").buildIndex);

    }

    public void gotoMenu(){
    
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //SceneManager.LoadScene(SceneManager.GetSceneByPath("MainMenu").buildIndex);

    }
    public void QuitGame (){

        Application.Quit();

    }
}
