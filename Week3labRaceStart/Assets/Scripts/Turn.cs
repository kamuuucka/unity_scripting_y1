using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    float turn;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        turn = Input.GetAxis("Horizontal");

        transform.Rotate(new Vector3(0,turn * speed,0));

        
    }
}
