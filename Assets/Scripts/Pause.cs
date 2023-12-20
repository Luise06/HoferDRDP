using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public RandomSpawner randomSpawner;
    public DragFingerMove dragFingerMove;
    public GameObject pauseScreen;
    bool pauseScreenEin;
    public Rigidbody2D korbRB;

    private void Start()
    {
        
    }
    public void PauseCanvas()
    {
        dragFingerMove.enabled = false;
        pauseScreen.SetActive(true);
        pauseScreenEin = true;
        Time.timeScale = 0;
        randomSpawner.enabled = false;
    }
    public void Weiter()
    {
        pauseScreen.SetActive(false);
            pauseScreenEin = false;
            dragFingerMove.enabled = true;
            randomSpawner.enabled = true;
        Time.timeScale = 1;
            //korbRB.transform.position = new Vector2(0, -4);
          
    }
}
