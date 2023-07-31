using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleObstacle : MonoBehaviour
{
    [SerializeField] float vehicleSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (this.vehicleSpeed * Time.deltaTime));
    }
}
