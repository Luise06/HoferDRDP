using UnityEngine;
using UnityEngine.UI;

public class gutscheinanzeigen : MonoBehaviour
{
    // Prefab für den Gutschein-Button
    public GameObject gutscheinButtonPrefab;
    // Eltern-Objekt, unter dem die Gutschein-Buttons erstellt werden
    public Transform buttonParent;

    void Start()
    {
        // Überprüfe, ob der Spieler einen Gutschein hat
        if (PlayerPrefs.HasKey("Gutschein"))
        {
            // Instanziere den Gutschein-Button
            GameObject gutscheinButton = Instantiate(gutscheinButtonPrefab, buttonParent);
            // Setze den Text des Buttons auf den Namen des Gutscheins
            string gutscheinName = PlayerPrefs.GetString("Gutschein");
            gutscheinButton.GetComponentInChildren<Text>().text = gutscheinName;
        }
    }
}

