using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour {
    [SerializeField] Text textTimer;

    public void btnReturn() {
        SceneManager.LoadScene("MainMenu");
    }
    void Start() {
        GameValues.time = 0;
    }

    void Update() {
        GameValues.time += Time.deltaTime;
        textTimer.text = FormatTime(GameValues.time);
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

