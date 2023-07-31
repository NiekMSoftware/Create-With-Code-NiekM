using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    float horizontalInput;

    [SerializeField] float xRange = 10;
    [SerializeField] float speed;

    [SerializeField] GameObject projectile;

    void Awake() {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update() {
        // Limit where the player can go to
        if (transform.position.x < -this.xRange) {
            transform.position = new Vector3(-this.xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > this.xRange) {
            transform.position = new Vector3(this.xRange, transform.position.y, transform.position.z);
        }
        
        // Move the player left and right
        this.horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (speed * this.horizontalInput * Time.deltaTime));

        if (Input.GetKeyDown(KeyCode.Space)) {
            // Launch a projectile from the player
            Instantiate(this.projectile, transform.position, this.projectile.transform.rotation);
        }
    }
}
