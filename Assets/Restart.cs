  using UnityEngine;
     using UnityEngine.SceneManagement;
     using System.Collections;
     
     public class Restart : MonoBehaviour {
     
         public void RestartGame() {
             SceneManager.LoadScene("SampleScene"); // loads current scene
             Time.timeScale = 1f;
         }

         public void doExitGame() {
         Application.Quit();
 }
     
     }