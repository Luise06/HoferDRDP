using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRandomItem : MonoBehaviour
{
    public GameObject[] itemSuchen;
    public string gesuchterTagName;
    public int randomFillObjekt;
    int randomItemNumber;

    private void Awake()
    {
        RandomObjektausWahl();
    }
    public void RandomObjektausWahl()
    {
        for (int i = 0; i < itemSuchen.Length; i++)
        {
            itemSuchen[i].SetActive(false);
        }
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-2, 3), 7, 0);
        //GameObject insTantiatObj = ;
        randomItemNumber = Random.Range(0, itemSuchen.Length);
        //Instantiate(itemSuchen[randomItemNumber], new Vector3(0, 2.75f, 0), Quaternion.identity);
        itemSuchen[randomItemNumber].SetActive(true);
        gesuchterTagName = itemSuchen[randomItemNumber].tag;
        Debug.Log(gesuchterTagName);
        randomFillObjekt = Random.Range(0, itemSuchen.Length);
    }
    private void Update()
    {
        if (randomFillObjekt == randomItemNumber)
        {
            randomFillObjekt = Random.Range(0, itemSuchen.Length);
        }
    }
}
