using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyProjectile : MonoBehaviour {
    [SerializeField] float topBound = 30;
    [SerializeField] float lowerBound = -10;

    // Update is called once per frame
    void Update() {
        if (transform.position.z > this.topBound) {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound) {
            Destroy(gameObject);
        }
    }
}
