using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRandomItem : MonoBehaviour
{
    public GameObject[] abgewandeltesItemArray;
    //public int[] abgewandeltesItemInt;
    public GameObject[] itemsSuchen;
    public string gesuchterTagName;
    public int randomItemNumberArray;
    public int randomItemNumber;

    /*public GameObject[] abgewandeltesItem;
    public GameObject[] abgewandeltesItem1;
    public GameObject[] abgewandeltesItem2;
    public GameObject[] abgewandeltesItem3;
    public GameObject[] abgewandeltesItem4;
    public GameObject[] abgewandeltesItem5;*/

    private void Awake()
    {
        RandomObjektausWahl();
    }
    public void RandomObjektausWahl()
    {
        for (int i = 0; i < abgewandeltesItemArray.Length; i++)
        {
            abgewandeltesItemArray[i].SetActive(false);
        }
        randomItemNumberArray = Random.Range(0, abgewandeltesItemArray.Length);
        abgewandeltesItemArray[randomItemNumberArray].SetActive(true);
        gesuchterTagName = abgewandeltesItemArray[randomItemNumberArray].tag;
        randomItemNumber = Random.Range(0, 6);
        //abgewandeltesItemArray[randomItemNumberArray].gameObject[randomItemNumber];
    }
}
