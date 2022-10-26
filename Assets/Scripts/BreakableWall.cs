using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWall : MonoBehaviour
{
    public Rigidbody wallPiece1;
    public Rigidbody wallPiece2;
    public Rigidbody wallPiece3;
    public Rigidbody wallPiece4;
    public Rigidbody wallPiece5;
    public BoxCollider boxCollider;

    void BreakApart()
    {
        boxCollider.enabled = false;
        wallPiece1.isKinematic = false;
        wallPiece2.isKinematic = false;
        wallPiece3.isKinematic = false;
        wallPiece4.isKinematic = false;
        wallPiece5.isKinematic = false;
        wallPiece1.useGravity = true;
        wallPiece2.useGravity = true;
        wallPiece3.useGravity = true;
        wallPiece4.useGravity = true;
        wallPiece5.useGravity = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 10)
            BreakApart();
    }
}
