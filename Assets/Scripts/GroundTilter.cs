using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTilter : MonoBehaviour
{
    private Rigidbody rb;
    Vector3 rotateVector = new Vector3(0, 0, 0);
    Vector3 moveVector = new Vector3(0, 0, 0);

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey("up"))
        {
            rotateVector.x += 0.07f;
        }
        if (Input.GetKey("down"))
        {
            rotateVector.x -= 0.07f;
        }
        if (Input.GetKey("right"))
        {
            rotateVector.z -= 0.07f;
        }
        if (Input.GetKey("left"))
        {
            rotateVector.z += 0.07f;
        }
    }

    void FixedUpdate()
    {
        transform.eulerAngles = rotateVector;
    }
}
