using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBlink : MonoBehaviour {
    [SerializeField] Text text;
    [SerializeField] Color color1;
    [SerializeField] Color color2;
    [SerializeField] float blinkSpeed = 0.4f;

    void Update() {
        text.color = Color.Lerp(color1, color2, Mathf.PingPong(Time.time, blinkSpeed));
    }
}
