using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public PlayerController Player;
    public GameObject Self;
    public GameObject PlayerObj;
    public GameObject Particle;
    public Transform PickUpParent;

    void Start()
    {
        PlayerObj = GameObject.Find("Player");
        PickUpParent = GameObject.Find("PickUp Parent").transform;
        Player = PlayerObj.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("WallChunk"))
        {
            Player.count++;
            Player.SetCountText();

            if (Player.remaining > 0)
            {
                Player.remaining--;
                Player.SetRemainingText();
            }

            GameObject particleInstance = Instantiate(Particle, transform);
            particleInstance.transform.SetParent(PickUpParent, true);
            Self.SetActive(false);
        }
    }
}