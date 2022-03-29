using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuiceController : MonoBehaviour {
    Rigidbody2D rb;
    [SerializeField] float speedMin = 0.15f;
    [SerializeField] float speedMax = 0.3f;
    
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        float speed = Random.Range(speedMin, speedMax);
        rb.AddForce(Random.onUnitSphere * speed, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Die") {
            Destroy(gameObject);
        }
    }
}
