using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    ChooseRandomItem chooseRandomItem;
    [SerializeField] Transform[] spawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        int randomPosition = Random.Range(0,spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (i != chooseRandomItem.randomFillObjekt)
            {
                Debug.Log("Statement ausführen");
                Instantiate(chooseRandomItem.itemSuchen[chooseRandomItem.randomFillObjekt], spawnPoints[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
