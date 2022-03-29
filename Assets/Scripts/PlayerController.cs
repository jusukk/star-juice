using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    Rigidbody2D rb;
    [SerializeField] float speed = 100.0f;
    [SerializeField] float speedTilt = 8.0f;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        float xInput = Input.GetAxis("Horizontal");
        // Tilt movement, else xinput
        if (Input.accelerationEventCount > 0) rb.AddForce(new Vector2(Input.acceleration.x,0)*speedTilt);
        rb.AddForce(new Vector2(xInput * speed * Time.deltaTime, 0));
    }

}