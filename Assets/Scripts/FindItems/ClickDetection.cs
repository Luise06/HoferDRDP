using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickDetection : MonoBehaviour
{
    ChooseRandomItem chooseRandomItem;
    ScoreFindItem scoreFindItem;

    private void Start()
    {
        chooseRandomItem = GameObject.Find("GameManager").GetComponent<ChooseRandomItem>();
        scoreFindItem = GameObject.Find("GameManager").GetComponent<ScoreFindItem>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(clickPosition, Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject == gameObject)
                {
                    
                    if (gameObject.tag == chooseRandomItem.gesuchterTagName)
                    {
                        scoreFindItem.findItemScore++;
                        chooseRandomItem.RandomObjektausWahl();
                    }
                    
                }
            }
        }
    }
}