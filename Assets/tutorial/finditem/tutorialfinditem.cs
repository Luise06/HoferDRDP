using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialfinditem : MonoBehaviour
{
    public GameObject tutorial;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
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
        Time.timeScale = 1f;

    }

}
