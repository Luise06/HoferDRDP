using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickDetection : MonoBehaviour
{
    public ChooseRandomItem chooseRandomItem;
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
                        SceneManager.LoadScene(0);
                    }
                    
                }
            }
        }
    }
}