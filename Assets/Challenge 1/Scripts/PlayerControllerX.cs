using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    public float frontInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // get the user's horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        // get the user's forward input
        frontInput = Input.GetAxis("Run");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * (speed * Time.deltaTime * frontInput));

        // tilt the plane left/right based on left/right arrow keys
        transform.Rotate(Vector3.right * (rotationSpeed * Time.deltaTime * verticalInput));

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime * horizontalInput));
    }
}
