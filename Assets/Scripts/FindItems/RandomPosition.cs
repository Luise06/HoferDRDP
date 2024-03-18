using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    public ChooseRandomItem chooseRandomItem;
    [SerializeField] Transform[] spawnPoints;
    int randomPosition;
    
    void Start()
    {

        FillObjektsSpawn();
        
    }
    public void FillObjektsSpawn()
    {
        randomPosition = Random.Range(0, spawnPoints.Length);
        Instantiate(chooseRandomItem.abgewandeltesItem[chooseRandomItem.randomItemNumber], spawnPoints[randomPosition]);
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Debug.Log(randomPosition);
            
            if (i != randomPosition)
            {
                GameObject instantiateObj = chooseRandomItem.itemsSuchen[chooseRandomItem.randomItemNumber];
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
            //Debug.Log(i);
        }
        
        FillObjektsSpawn();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
