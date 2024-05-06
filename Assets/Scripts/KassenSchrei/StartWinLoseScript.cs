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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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
        mainCanvas.SetActive(true);
        bgImage.color = Color.white;
    }
    public void HomeButton()
    {
        SceneManager.LoadScene(0);
    }
}
