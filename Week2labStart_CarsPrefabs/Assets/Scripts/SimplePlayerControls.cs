using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerControls : MonoBehaviour
{
	public float speed=1;

    Rigidbody rb;
    Vector3 startPosition;

    void Start()
    {
		rb=GetComponent<Rigidbody>();
		startPosition = transform.position;
    }

    void FixedUpdate()
    {
		Vector3 moveVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

		//transform.Translate(moveVector * speed);
        rb.AddForce(moveVector * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            ResetPosition();
        }
        
    }

    void ResetPosition() {
        if (rb != null) {
            rb.position = startPosition;
        } else {
            Debug.Log("Warning: no rigidbody attached to player");
        }
    }


    /*
     * Rigidbody rb;
    public float force;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per physics frame (a fixed #times per second)
    void FixedUpdate()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //transform.position += move * Time.deltaTime; // bad! (with physics)

        rb.AddForce(move * force);

    }*/
}
