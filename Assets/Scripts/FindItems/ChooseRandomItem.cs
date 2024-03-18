using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRandomItem : MonoBehaviour
{
    public GameObject[] abgewandeltesItem;
    public GameObject[] itemsSuchen;
    public string gesuchterTagName;
    //public int randomFillObjekt;
    public int randomItemNumber;

    private void Awake()
    {
        RandomObjektausWahl();
    }
    public void RandomObjektausWahl()
    {

        for (int i = 0; i < abgewandeltesItem.Length; i++)
        {
            abgewandeltesItem[i].SetActive(false);
        }
        //Vector3 randomSpawnPosition = new Vector3(Random.Range(-2, 3), 7, 0);
        //GameObject insTantiatObj = ;
        randomItemNumber = Random.Range(0, abgewandeltesItem.Length);
        //Instantiate(itemSuchen[randomItemNumber], new Vector3(0, 2.75f, 0), Quaternion.identity);
        abgewandeltesItem[randomItemNumber].SetActive(true);
        gesuchterTagName = abgewandeltesItem[randomItemNumber].tag;
        
        //randomFillObjekt = Random.Range(0, itemSuchen.Length);
        //Debug.Log(randomFillObjekt);
    }
    
    
}
