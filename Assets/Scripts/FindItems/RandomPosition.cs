using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    /*public ChooseRandomItem chooseRandomItem;
    public RandomArray randomArray;
    public Transform[] spawnPoints;
    public int randomPosition;
    
    void Start()
    {

        FillObjektsSpawn();
        
    }
    public void FillObjektsSpawn()
    {
        randomPosition = Random.Range(0, spawnPoints.Length);
        randomArray.RandomArrayausWahl();
        
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Debug.Log(randomPosition);
            
            if (i != randomPosition)
            {
                GameObject instantiateObj = chooseRandomItem.itemsSuchen[chooseRandomItem.randomItemNumberArray];
                instantiateObj.SetActive(true);
                Instantiate(instantiateObj, spawnPoints[i]);

            }
        }
       
    }
    public void DestroyGameObjekts()
    {
        
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Destroy(spawnPoints[i].GetChild(1).gameObject);

        }
        
        FillObjektsSpawn();
    }*/
}
