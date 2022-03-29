using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootStar : MonoBehaviour {
    [SerializeField] float waitTime = 1f;
    [SerializeField] GameObject star;
    IEnumerator coroutine;
    
    void Start() {
        coroutine = WaitAndShoot(waitTime);
        StartCoroutine(coroutine);
    }

    void Shoot() {
        Vector2 pos = new Vector2(transform.position.x + Random.Range(-1.5f, 1.5f), transform.position.y + Random.Range(-1f, 1f));
        Instantiate(star, pos, transform.rotation);
    }

    IEnumerator WaitAndShoot(float waitTime) {
        while (true) {
             yield return new WaitForSeconds(waitTime);
             Shoot();
        }
    }
}
