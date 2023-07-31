using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Destroyer")) {
            Destroy(GameObject.FindWithTag("Animal"));
        }
        else {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
