using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseFindItems : MonoBehaviour
{
    bool pauseButtongedruckt;
    public GameObject pauseScreen;
    public TimeManager timeManager;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PauseButtongedrueckt()
    {
        pauseButtongedruckt = true;
        pauseScreen.SetActive(true);
        Time.timeScale = 0;
        timeManager.pause = true;
    }
    public void HomeButton()
    {
        SceneManager.LoadScene(0);
    }
    public void Levelauswahlbutton()
    {
        SceneManager.LoadScene(1);
    }
    public void Weiter()
    {
        pauseButtongedruckt = false;
        pauseScreen.SetActive(false);
        Time.timeScale = 1;
        timeManager.pause = false;
    }
}
