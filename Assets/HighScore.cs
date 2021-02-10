using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
     public static int scoreValue = 0;
 
    Text hscore;
    // Start is called before the first frame update
    void Start()
    {
        hscore = GetComponent<Text>();
        hscore.text ="HighScore" + PlayerPrefs.GetInt("Highscore", 0).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        hscore.text ="HighScore " + scoreValue.ToString();

        if(scoreValue > PlayerPrefs.GetInt("HighScore", 0)){
            
            PlayerPrefs.SetInt("HighScore", scoreValue);
            hscore.text = "HighScore " + scoreValue.ToString();
        }
        
    }
}
