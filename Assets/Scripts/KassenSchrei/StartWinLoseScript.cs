using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartWinLoseScript : MonoBehaviour
{
    [SerializeField] GameObject mainCanvas;
    [SerializeField] GameObject tutorialCanvas;
    [SerializeField] SpriteRenderer bgImage;
    [SerializeField] GameObject winScreen;
    [SerializeField] GameObject loseScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScaleFromMic.spielVerloren)
        {
            loseScreen.SetActive(true);
            bgImage.color = new Color32(190, 190, 190, 255);
            mainCanvas.SetActive(false);
        }
        if (ScaleFromMic.spielGewonnen)
        {
            winScreen.SetActive(true);
            bgImage.color = new Color32(190, 190, 190, 255);
            mainCanvas.SetActive(false);
        }
    }

    public void PlayButton()
    {
        mainCanvas.SetActive(true);
        tutorialCanvas.SetActive(false);
        bgImage.color = Color.white;
    }
    public void XButton()
    {
        SceneManager.LoadScene(1);
    }
    public void MenuButton()
    {
        mainCanvas.SetActive(false);
        tutorialCanvas.SetActive(true);
        bgImage.color = new Color32(190,190,190,255);
    }
    public void RestartGame()
    {
        ScaleFromMic.spielVerloren = false;
        ScaleFromMic.spielGewonnen = false;
        mainCanvas.SetActive(true);
        loseScreen.SetActive(false);
        winScreen.SetActive(false);
        bgImage.color = Color.white;

    }
}
