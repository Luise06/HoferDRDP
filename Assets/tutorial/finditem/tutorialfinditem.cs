using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialfinditem : MonoBehaviour
{
    public GameObject tutorial;
    public TimeManager timeManager;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Return()
    {
        SceneManager.LoadScene("Spielauswahl");
    }

    public void Spielen()
    {
        tutorial.SetActive(false);
        timeManager.TutorialSchliesen();
        Time.timeScale = 1;

    }

}
