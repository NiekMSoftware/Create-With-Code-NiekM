using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    
    float _verticalInput;

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        this._verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * (this._verticalInput * this.rotationSpeed * Time.deltaTime));
    }
}
