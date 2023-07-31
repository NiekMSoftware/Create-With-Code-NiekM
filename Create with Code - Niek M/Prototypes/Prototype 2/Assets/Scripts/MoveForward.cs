using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {
    [SerializeField] float speed = 40f;

    // Update is called once per frame
    void Update(){
        transform.Translate(Vector3.forward * (this.speed * Time.deltaTime));
    }
}
