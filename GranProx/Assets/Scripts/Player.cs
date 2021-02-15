using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;
    private Rigidbody body;

    void Start()
    {
        body = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        HandleInput();

        
    }

    
    private void HandleInput()
    {
        float translate = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotateSpeed;

        translate *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(new Vector3(0.0f, 0.0f, translate));
        transform.Rotate(new Vector3(0.0f, rotation, 0.0f));
    }
}
