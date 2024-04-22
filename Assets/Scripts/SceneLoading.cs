using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading: MonoBehaviour
{
    
    public void ZumSpiel()
    {
        SceneManager.LoadScene("foodDrop");
    }
    
    public void Rabatte()
    {

    }
    public void Zurueck()
    {
        SceneManager.LoadScene(0);
    }
}
