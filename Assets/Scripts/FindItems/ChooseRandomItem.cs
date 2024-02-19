using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRandomItem : MonoBehaviour
{
    [SerializeField] GameObject[] itemSuchen;
    public string gesuchterTagName;

    private void Start()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-2, 3), 7, 0);
        //GameObject insTantiatObj = ;
        int randomItemNumber = Random.Range(0, itemSuchen.Length - 1);
        Instantiate(itemSuchen[randomItemNumber], new Vector3(0, 2.75f, 0), Quaternion.identity);
        gesuchterTagName = itemSuchen[randomItemNumber].tag;
        Debug.Log(gesuchterTagName);
    }
}
