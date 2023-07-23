using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 5.0f;
    private float turnSpeed = 25;
    private float horizonalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
    }

    
    void Update()
    {
        horizonalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(speed * forwardInput * Time.deltaTime * Vector3.forward);
        transform.Rotate(Vector3.up, turnSpeed * horizonalInput * Time.deltaTime);
    }
}
