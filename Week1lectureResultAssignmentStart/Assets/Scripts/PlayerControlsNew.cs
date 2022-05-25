using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsNew : MonoBehaviour
{
    public float ratationSpeed = 0.1f;
    public float movementSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        Vector3 moveVector = new Vector3(0, 0, Input.GetAxis("Vertical")) * movementSpeed;

        transform.Rotate(0, Input.GetAxis("Mouse X") * ratationSpeed, 0);
        //transform.Translate();
        transform.position += moveVector;

        if (moveVector.magnitude > 0)
        {
            transform.rotation = Quaternion.LookRotation(moveVector);
        }
    }
}
