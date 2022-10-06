using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBox : MonoBehaviour
{
    public bool unlocked;
    public Material unlockedMaterial;

    void update()
    {
        if (unlocked)
        {
            Debug.Log("cock");
            GetComponent<MeshRenderer>().material = unlockedMaterial;
        }
    }
}
