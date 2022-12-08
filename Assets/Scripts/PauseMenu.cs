using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    bool isPaused;
    public GameObject Menu;

    // Start is called before the first frame update
    void Start()
    {
        Pause();
    }

    void Pause()
    {
        Time.timeScale = 0;
        Menu.SetActive(true);
        isPaused = true;
    }

    public void Unpause()
    {
        Time.timeScale = 1;
        Menu.SetActive(false);
        isPaused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown("return") || Input.GetKeyDown("escape"))
        {
            if (isPaused)
                Unpause();
            else
                Pause();
        }
    }
}
