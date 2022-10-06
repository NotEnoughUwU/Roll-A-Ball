using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    bool rotateLeftCheck;
    bool rotateRightCheck; 

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            rotateLeftCheck = true;
        }
        else if (Input.GetKeyUp("q"))
        {
            rotateLeftCheck = false;
        }
        if (Input.GetKeyDown("e"))
        {
            rotateRightCheck = true;
        }
        else if (Input.GetKeyUp("e"))
        {
            rotateRightCheck = false;
        }
    }
    void FixedUpdate()
    {
        if (rotateLeftCheck)
        {
            transform.RotateAround(player.transform.position, Vector3.up, -5);
            offset = transform.position - player.transform.position;
        }
        if (rotateRightCheck)
        {
            transform.RotateAround(player.transform.position, Vector3.up, 5);
            offset = transform.position - player.transform.position;
        }
    }
}
