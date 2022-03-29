using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speeeen : MonoBehaviour {
    [SerializeField] float speedSpinMin = 40f;
    [SerializeField] float speedSpinMax = 80f;
    float spinX;
    float spinY;
    float spinZ;

    void Start() {
        spinX = Random.Range(speedSpinMin, speedSpinMax);
        spinY = Random.Range(speedSpinMin, speedSpinMax);
        spinZ = Random.Range(speedSpinMin, speedSpinMax);
    }

    void Update() {
        transform.Rotate(spinX * Time.deltaTime, spinY * Time.deltaTime, spinZ * Time.deltaTime);
    }
}
