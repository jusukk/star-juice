using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {
    [SerializeField] float speedMin = 1f;
    [SerializeField] float speedMax = 3f;
    [SerializeField] int spwanAmount = 10;

    [SerializeField] GameObject star;
    [SerializeField] SpriteRenderer starGlow;
    [SerializeField] ParticleSystem psStar;
    [SerializeField] ParticleSystem psDie;
    [SerializeField] TrailRenderer trailStar;

  
    [SerializeField] GameObject juice;
    Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        float speed = Random.Range(speedMin,speedMax);
        rb.AddForce(Vector2.left * speed, ForceMode2D.Impulse);

        Destroy(gameObject, 7);
    }


    void OnMouseDown() {
        if (starGlow.enabled) {
            for(int i = 0; i < spwanAmount; i++){
                Instantiate(juice, transform.position, transform.rotation);
            } 
            star.GetComponent<Renderer> ().enabled = false;
            starGlow.enabled = false;
            psStar.Stop();
            psDie.Play();
            trailStar.emitting = false;  
        }

    }
}
