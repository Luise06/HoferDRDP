using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartWinLoseScript : MonoBehaviour
{
    [SerializeField] GameObject mainCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayButton()
    {
        mainCanvas.SetActive(true);
    }
}
