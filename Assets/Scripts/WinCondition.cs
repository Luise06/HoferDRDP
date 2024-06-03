using UnityEngine;

public class WinCondition : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("4"))
        {
            GameManagment.Instance.GameWon();
        }
    }
}


