using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    bool rotateLeftCheck;
    bool rotateRightCheck;

    public string leftRotate;
    public string rightRotate;

    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.transform.position + new Vector3(0,16,-11);
        offset = transform.position - player.transform.position;

        rotateSpeed = 2;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
    void Update()
    {
        if (Input.GetKeyDown(leftRotate))
        {
            rotateLeftCheck = true;
        }
        else if (Input.GetKeyUp(leftRotate))
        {
            rotateLeftCheck = false;
        }
        if (Input.GetKeyDown(rightRotate))
        {
            rotateRightCheck = true;
        }
        else if (Input.GetKeyUp(rightRotate))
        {
            rotateRightCheck = false;
        }
    }
    void FixedUpdate()
    {
        if (rotateLeftCheck)
        {
            transform.RotateAround(player.transform.position, Vector3.up, -rotateSpeed);
            offset = transform.position - player.transform.position;
        }
        if (rotateRightCheck)
        {
            transform.RotateAround(player.transform.position, Vector3.up, rotateSpeed);
            offset = transform.position - player.transform.position;
        }
    }

    public void InvertControls()
    {
        if (leftRotate == "q")
        {
            leftRotate = "e";
            rightRotate = "q";
        }
        else if (leftRotate == "e")
        {
            leftRotate = "q";
            rightRotate = "e";
        }
    }
}