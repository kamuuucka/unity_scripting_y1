using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerate : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private bool gounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (CheckGrounded())
        {
            Move();
            rb.velocity *= 0.98f;
        }
    }

    private void Move()
    {
        Vector3 moveVector = transform.forward * Input.GetAxis("Vertical");

        rb.AddForce(moveVector * speed);
    }

    private bool CheckGrounded()
    {
        Vector3 origin = transform.position;
        Vector3 direction = new Vector3(0, -1, 0);
        float maxDistance = 1.1f;
        RaycastHit hitInfo;

        if (Physics.Raycast(origin, direction, out hitInfo, maxDistance))
        {
            return true;
        }
        return false;
    }
}
