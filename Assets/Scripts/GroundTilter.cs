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
        if (Input.GetKeyDown("up") || Input.GetKeyDown("w"))
        {
            upPressed = true;
        }
        else if (Input.GetKeyUp("up") || Input.GetKeyUp("w"))
        {
            upPressed = false;
        }
        if (Input.GetKeyDown("down") || Input.GetKeyDown("s"))
        {
            downPressed = true;
        }
        else if (Input.GetKeyUp("down") || Input.GetKeyUp("s"))
        {
            downPressed = false;
        }
        if (Input.GetKeyDown("right") || Input.GetKeyDown("d"))
        {
            rightPressed = true;
        }
        else if (Input.GetKeyUp("right") || Input.GetKeyUp("d"))
        {
            rightPressed = false;
        }
        if (Input.GetKeyDown("left") || Input.GetKeyDown("a"))
        {
            leftPressed = true;
        }
        else if (Input.GetKeyUp("left") || Input.GetKeyUp("a"))
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
        //transform.eulerAngles = rotateVector;

        if (upPressed)
        {
            //rotateVector.x += 0.8f;
            transform.Rotate(Camera.main.transform.right, 1, Space.World);
        }
        if (downPressed)
        {
            //rotateVector.x -= 0.8f;
            transform.Rotate(Camera.main.transform.right, -1, Space.World);
        }
        if (rightPressed)
        {
            //rotateVector.z -= 0.8f;
            transform.Rotate(Camera.main.transform.forward, -0.5f, Space.World);
            transform.Rotate(Camera.main.transform.up, -0.5f, Space.World);
        }
        if (leftPressed)
        {
            //rotateVector.z += 0.8f;
            transform.Rotate(Camera.main.transform.forward, 0.5f, Space.World);
            transform.Rotate(Camera.main.transform.up, 0.5f, Space.World);
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
