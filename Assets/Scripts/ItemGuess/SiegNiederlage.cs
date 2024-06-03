using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SiegNiederlage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GewonnnenOderVerloren()
    {
        if (Eventyy.Score >= 2)
        {
            StaticVariablen.hatHighscore = false;
            StaticVariablen.gewonnen = "Glückwunsch!!!";
            StaticVariablen.whichScene = "ItemGuesser";
            SceneManager.LoadScene(4);
        }
        else
        {
            StaticVariablen.hatHighscore = false;
            StaticVariablen.gewonnen = "Schade";
            StaticVariablen.whichScene = "ItemGuesser";
            SceneManager.LoadScene(4);
        }
    }
}
