using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRandomItem : MonoBehaviour
{
    [SerializeField] GameObject[] itemSuchen;
    public string gesuchterTagName;

    private void Start()
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
        int randomItemNumber = Random.Range(0, itemSuchen.Length - 1);
        //Instantiate(itemSuchen[randomItemNumber], new Vector3(0, 2.75f, 0), Quaternion.identity);
        itemSuchen[randomItemNumber].SetActive(true);
        gesuchterTagName = itemSuchen[randomItemNumber].tag;
        Debug.Log(gesuchterTagName);
    }
}
