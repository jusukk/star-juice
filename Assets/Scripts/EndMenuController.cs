using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndMenuController : MonoBehaviour {
    [SerializeField] Text textBestTime;
    [SerializeField] Text textTime;
    [SerializeField] Color color1;
    [SerializeField] Color color2;
    [SerializeField] float blinkSpeed = 0.4f;

    void Start() {
        if (GameValues.time < GameValues.bestTime) {
            GameValues.bestTime = GameValues.time;
            textBestTime.text = "NEW BEST TIME: " + FormatTime(GameValues.bestTime);
            PlayerPrefs.SetFloat("BestTime", GameValues.bestTime);
        }
        else textBestTime.text = "BEST TIME: " + FormatTime(GameValues.bestTime);
        textTime.text = "TIME: " + FormatTime(GameValues.time);
    }

    void Update() {
        // If new highscore, blink text
        if (GameValues.time <= GameValues.bestTime) textBestTime.color = Color.Lerp(color1, color2, Mathf.PingPong(Time.time, blinkSpeed));
    }

    public void btnReturn() {
        SceneManager.LoadScene("MainMenu");
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
