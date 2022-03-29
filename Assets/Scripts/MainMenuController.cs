using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {
    [SerializeField] Text textBestTime;

    void Start() {
        if (PlayerPrefs.HasKey("BestTime")) GameValues.bestTime = PlayerPrefs.GetFloat("BestTime");
        textBestTime.text = "BEST TIME: " + FormatTime(GameValues.bestTime);
    }

    public void btnStart() {
        SceneManager.LoadScene("Level");
    }

    public void btnExit() {  
        Application.Quit(); 
    }  

    // Format time mm:ss:ms
    string FormatTime (float time){
        int intTime = (int)time;
        int min = intTime / 60;
        int s = intTime % 60;
        float ms = time * 100;
        ms = Mathf.Floor((ms % 100));
        string timeText = string.Format ("{0:00}:{1:00}:{2:00}", min, s, ms);
        return timeText;
    }

}
