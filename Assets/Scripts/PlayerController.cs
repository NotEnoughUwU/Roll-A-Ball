using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public Transform fieldTransform;
    public GroundTilter PlayingField;
    public int yMod = 1;

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
        if(count >= 22) 
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
            GetComponent<Rigidbody>().Sleep();
            GroundTilter.resetCheck = true;
            transform.SetParent(null);
            transform.eulerAngles = new Vector3(0, 0, 0);
            transform.position = new Vector3(-5, 8, 8);
            transform.SetParent(fieldTransform, false);
        }
        else if (other.gameObject.CompareTag("pushup"))
        {
            transform.position = new Vector3( transform.position.x, transform.position.y + yMod, transform.position.z );
        }
    }
}
