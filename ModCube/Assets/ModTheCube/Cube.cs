using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float speed;
    public float rotationSpeed;

    float _angles;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);

        this._angles = Random.Range(0f, 15f);
    }
    
    void Update()
    {
        transform.Rotate(this._angles * this.rotationSpeed * Time.deltaTime, 
                            this._angles * this.rotationSpeed * Time.deltaTime,
                            this._angles * this.rotationSpeed * Time.deltaTime);
    }
}
