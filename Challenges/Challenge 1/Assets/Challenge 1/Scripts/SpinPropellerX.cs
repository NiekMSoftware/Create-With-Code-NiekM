using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour {
    [SerializeField] float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        // Rotate the propeller every frame
        transform.Rotate(Vector3.forward * (this.rotationSpeed * Time.deltaTime));
    }
}
