using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallChunk : MonoBehaviour
{
    public GameObject Self;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            Self.SetActive(false);
        }
    }
}
