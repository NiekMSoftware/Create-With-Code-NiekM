using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour {
    [SerializeField] GameObject cam1;
    [SerializeField] GameObject cam2;

    [SerializeField] bool player1;
    [SerializeField] bool player2;

    // Update is called once per frame
    void Update()
    {
        if (this.player1) {
            // Set the camera to first person
            if (Input.GetKeyDown(KeyCode.Alpha1)) {
                this.cam1.SetActive(false);
                this.cam2.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2)) {
                this.cam2.SetActive(false);
                this.cam1.SetActive(true);
            }
        }
        else if (this.player2) {
            // Set the camera to first person
            if (Input.GetKeyDown(KeyCode.Keypad0)) {
                this.cam1.SetActive(false);
                this.cam2.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.Keypad1)) {
                this.cam2.SetActive(false);
                this.cam1.SetActive(true);
            }
        }
        
    }
}
