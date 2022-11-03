using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureCamLookAtPlayer : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(target);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
    }
}
