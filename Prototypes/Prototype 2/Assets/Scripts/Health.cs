using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Health : MonoBehaviour {
    public TMP_Text text;
    public int health;
    public GameObject gameOver;
    
    void Update() {
        this.text.text = "" + this.health;

        if (health < 1) {
            this.gameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
