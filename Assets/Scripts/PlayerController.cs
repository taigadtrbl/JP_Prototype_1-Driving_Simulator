using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private readonly float _speed = 10f;
    private readonly float _turnSpeed = 30f;
    private float _horizontalInput;
    private float _forwardInput;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    public string inputID;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Assign Keys
        _horizontalInput = Input.GetAxis("Horizontal" + inputID);
        _forwardInput = Input.GetAxis("Vertical" + inputID);
        // Move The Vehicle Forward
        transform.Translate(Vector3.forward * (Time.deltaTime * _speed * _forwardInput));
        // Turn Left Or Right
        transform.Rotate(Vector3.up, (Time.deltaTime * _turnSpeed * _horizontalInput));

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}