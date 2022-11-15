using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    public Transform Field;

    public Vector3 BasePos;

    void Start()
    {
        BasePos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    void Update()
    {
        float amountToMove = Field.eulerAngles.x;
        if (amountToMove > 180)
        {
            amountToMove = (360 - amountToMove) * -1;
        }
        amountToMove /= 8;
        amountToMove *= -1;

        transform.position = BasePos + new Vector3(0, 0, amountToMove);
    }
}