using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject player;
    public GameObject exit;

    void Update()
    {
        transform.position = player.transform.position;
        transform.LookAt(exit.transform.position);
        transform.eulerAngles += new Vector3(180, 0, 180);
    }
}