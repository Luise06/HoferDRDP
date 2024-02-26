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
            //GameObject insTaniatObj = chooseRandomItem.itemSuchen[chooseRandomItem.randomItemNumber];
            //Instantiate(insTantiatObj, randomSpawnPosition, Quaternion.identity);
            Instantiate(chooseRandomItem.itemSuchen[0]);
            if (i != chooseRandomItem.randomFillObjekt)
            {
                Debug.Log("Statement ausführen");
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
