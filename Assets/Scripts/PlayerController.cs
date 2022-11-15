using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public TextMeshProUGUI remainingText;
    public Transform fieldTransform;
    public GroundTilter PlayingField;
    public ExitBox exitBox;
    public Material unlockedMaterial;
    public GameObject Key;

    public int yMod = 1;
    public int pickupCount;

    public float startX;
    public float startY;
    public float startZ;

    public int count;
    public int remaining;

    void Start()
    {
        count = 0;
        remaining = pickupCount;
        transform.position = new Vector3(startX, startY, startZ);
        SetCountText();
        SetRemainingText();
    }

    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            ResetBall();
        }
    }

    public void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= pickupCount)
        {
            Key.SetActive(true);
            exitBox.unlocked = true;
        }
    }

    public void SetRemainingText()
    {
        remainingText.text = "Remaining: " + remaining.ToString();
    }

    void ResetBall()
    {
        GetComponent<Rigidbody>().Sleep();
        GroundTilter.resetCheck = true;
        transform.SetParent(null);
        transform.eulerAngles = new Vector3(0, 0, 0);
        transform.position = new Vector3(startX, startY, startZ);
        transform.SetParent(fieldTransform, false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            ResetBall();
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
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
