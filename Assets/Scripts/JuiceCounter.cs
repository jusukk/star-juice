using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JuiceCounter : MonoBehaviour {
    [SerializeField] Text textJuiceCount;
    [SerializeField]  float winCount = 100;
    float juiceCount = 0;

     void OnTriggerEnter2D (Collider2D other) {
          if (juiceCount < winCount) {
               juiceCount++;
               updateJuiceCount(); 
          }
          if (Mathf.Round(juiceCount/winCount*100) >= 100) {
               SceneManager.LoadScene("EndMenu");
          }
     }

     void OnTriggerExit2D (Collider2D other) {
          if(juiceCount > 0) {
               juiceCount--;
               updateJuiceCount();
          }    
     }

     void updateJuiceCount() {
          textJuiceCount.text = Mathf.Round(juiceCount/winCount*100) + "%";
     }

}
