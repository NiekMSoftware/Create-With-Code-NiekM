using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] float vehicleSpeed;
    [SerializeField] float turnSpeed;

    [SerializeField] bool p1;
    [SerializeField] bool p2;
    
    // Update is called once per frame
    void Update()
    {
        if (this.p1) {
            this.Player1Input();
        }
        else if (this.p2) {
            this.Player2Input();
        }
    }

    void Player1Input() {
        // Input of player1
        float hInputP1 = Input.GetAxis("Horizontal1");
        float vInputP1 = Input.GetAxis("Vertical1");
        
        // Move player1's vehicle based on their input
        transform.Translate(Vector3.forward * (this.vehicleSpeed * vInputP1 * Time.deltaTime));
        transform.Rotate(Vector3.up * (this.turnSpeed * hInputP1 * Time.deltaTime));
    }
    
    void Player2Input() {
        // Input of player1
        float hInput = Input.GetAxis("Horizontal2");
        float vInput = Input.GetAxis("Vertical2");
        
        // Move player1's vehicle based on their input
        transform.Translate(Vector3.forward * (this.vehicleSpeed * vInput * Time.deltaTime));
        transform.Rotate(Vector3.up * (this.turnSpeed * hInput * Time.deltaTime));
    }
}
