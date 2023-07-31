using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAnimal : MonoBehaviour {
    public Health playerHealth;
    
    void OnTriggerEnter(Collider other) {
        Destroy(GameObject.FindWithTag("Animal"));
        this.playerHealth.health--;
    }
}
