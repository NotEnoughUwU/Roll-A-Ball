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
    public ExitBox exitBox;
    public Material unlockedMaterial;
    public GameObject Key;

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
        if(count >= 14)
        {
            Key.SetActive(true);
            exitBox.unlocked = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;

            SetCountText();
        }
        else if (other.gameObject.CompareTag("Respawn"))
        {
            GetComponent<Rigidbody>().Sleep();
            GroundTilter.resetCheck = true;
            transform.SetParent(null);
            transform.eulerAngles = new Vector3(0, 0, 0);
            transform.position = new Vector3(0.5f, 8, -15);
            transform.SetParent(fieldTransform, false);
        }
        else if (other.gameObject.CompareTag("pushup"))
        {
            transform.position = new Vector3( transform.position.x, transform.position.y + yMod, transform.position.z );
        }
        else if (other.gameObject.CompareTag("exit"))
        {
            if (exitBox.unlocked)
            {
                other.gameObject.SetActive(false);
                winTextObject.SetActive(true);
            }
        }
    }
}
