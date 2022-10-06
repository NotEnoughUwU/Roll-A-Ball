using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBox : MonoBehaviour
{
    public bool unlocked;
    public Material unlockedMaterial;

    void Update()
    {
        if (unlocked && GetComponent<MeshRenderer>().material != unlockedMaterial)
        {
            GetComponent<MeshRenderer>().material = unlockedMaterial;
        }
    }
}
