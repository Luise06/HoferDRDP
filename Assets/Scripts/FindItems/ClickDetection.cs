using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickDetection : MonoBehaviour
{
    //ChooseRandomItem chooseRandomItem;
    //RandomPosition randomPosition;
    ScoreFindIt scoreFindItem;
   TextMeshProUGUI findScore;
    PositionRan positionRan;
    int minusPunkte = 5;
    TextMeshProUGUI minusScore;

    private void Start()
    {
        //chooseRandomItem = GameObject.Find("GameManager").GetComponent<ChooseRandomItem>();
        //randomPosition = GameObject.Find("GameManager").GetComponent<RandomPosition>();
        scoreFindItem = GameObject.Find("GameManager").GetComponent<ScoreFindIt>();
        minusScore = GameObject.Find("MinusText").GetComponent<TextMeshProUGUI>();
        findScore = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        positionRan = GameObject.Find("GameManager").GetComponent<PositionRan>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(clickPosition, Vector2.zero);

            if (hit.collider != null)
            {
                //Debug.Log("nicht null");
                if (hit.collider.gameObject == gameObject)
                {
                    if (gameObject.tag == "KeinHoferProdukt")
                    {
                        scoreFindItem.findItemScore++;
                        findScore.text =  scoreFindItem.findItemScore.ToString();
                        positionRan.DestroyInstanzen();
                        //chooseRandomItem.RandomObjektausWahl();
                        //randomPosition.DestroyGameObjekts();
                    }
                    else
                    {
                        minusPunkte--;
                        minusScore.text = minusPunkte.ToString();
                    }
                    
                }
            }
        }
        if (minusPunkte <= 0)
        {
            StaticVariablen.hatHighscore = false;
            StaticVariablen.gewonnen = "Schade";
            StaticVariablen.whichScene = "FindItem";
            SceneManager.LoadScene("GewonnenVerloren");
        }
    }
}