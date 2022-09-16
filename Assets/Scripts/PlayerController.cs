using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        count = 0;

        SetCountText();
        winTextObject.SetActive(false);
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 13) 
        {
            winTextObject.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }
        else if (other.gameObject.CompareTag("Respawn"))
        {
            transform.position = new Vector3(0, 5, 0);
        }
        else if (other.gameObject.CompareTag("pushup"))
        {
            transform.position = new Vector3( transform.position.x, transform.position.y + 1, transform.position.z );
        }
    }
}
