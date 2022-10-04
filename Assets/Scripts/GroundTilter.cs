using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTilter : MonoBehaviour
{
    private Rigidbody rb;
    Vector3 rotateVector = new Vector3(0, 0, 0);
    Vector3 moveVector = new Vector3(0, 0, 0);
    public static bool resetCheck = false;

    bool upPressed = false;
    bool downPressed = false;
    bool leftPressed = false;
    bool rightPressed = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            upPressed = true;
        }
        else if (Input.GetKeyUp("up"))
        {
            upPressed = false;
        }
        if (Input.GetKeyDown("down"))
        {
            downPressed = true;
        }
        else if (Input.GetKeyUp("down"))
        {
            downPressed = false;
        }
        if (Input.GetKeyDown("right"))
        {
            rightPressed = true;
        }
        else if (Input.GetKeyUp("right"))
        {
            rightPressed = false;
        }
        if (Input.GetKeyDown("left"))
        {
            leftPressed = true;
        }
        else if (Input.GetKeyUp("left"))
        {
            leftPressed = false;
        }

        if (resetCheck)
        {
            ResetRotation();
        }
    }

    void FixedUpdate()
    {
        transform.eulerAngles = rotateVector;

        if (upPressed)
        {
            rotateVector.x += 0.8f;
        }
        if (downPressed)
        {
            rotateVector.x -= 0.8f;
        }
        if (rightPressed)
        {
            rotateVector.z -= 0.8f;
        }
        if (leftPressed)
        {
            rotateVector.z += 0.8f;
        }
    }

    void ResetRotation()
    {
        moveVector = new Vector3(0, 0, -8);
        rotateVector = new Vector3(0, 0, 0);
        transform.eulerAngles = rotateVector;
        transform.position = moveVector;
        resetCheck = false;
    }
}
