using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickDetection : MonoBehaviour
{
    //ChooseRandomItem chooseRandomItem;
    //RandomPosition randomPosition;
    ScoreFindItem scoreFindItem;
   TextMeshProUGUI findScore;
    PositionRan positionRan;

    private void Start()
    {
        //chooseRandomItem = GameObject.Find("GameManager").GetComponent<ChooseRandomItem>();
        //randomPosition = GameObject.Find("GameManager").GetComponent<RandomPosition>();
        scoreFindItem = GameObject.Find("GameManager").GetComponent<ScoreFindItem>();
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
                        findScore.text = "Gefundene: " + scoreFindItem.findItemScore.ToString();
                        positionRan.DestroyInstanzen();
                        //chooseRandomItem.RandomObjektausWahl();
                        //randomPosition.DestroyGameObjekts();
                    }
                    
                }
            }
        }
    }
}