using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FppView : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 4, 2);
    public Camera firstCamera;
    public Camera secondCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

            if (Input.GetKeyDown(KeyCode.C))
            {
                firstCamera.enabled = true;
                secondCamera.enabled = false;
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                firstCamera.enabled = false;
                secondCamera.enabled = true;
            }
    }
}
