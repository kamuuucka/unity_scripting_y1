using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsNew : MonoBehaviour
{
    public float rotationSpeed = 0.1f;
    public float movementSpeed = 1.0f;
    public float minimumX;
    public float minimumZ;
    public float maximumX;
    public float maximumZ;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        Bounds();
    }

    private void PlayerMove()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * rotationSpeed, 0);

        transform.Translate(Vector3.forward * movementSpeed * Input.GetAxis("Vertical"));
        transform.Translate(Vector3.right * movementSpeed * Input.GetAxis("Horizontal"));

    }

    private void Bounds()
    {
        if (gameObject.transform.position.x <= minimumX || gameObject.transform.position.x >= maximumX
            || gameObject.transform.position.z <= minimumZ || gameObject.transform.position.z >= maximumZ)
        {

            transform.position = new Vector3(0, 1, 0);
        }
    }
}
