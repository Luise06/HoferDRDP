using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionRan : MonoBehaviour
{
    int richtigePos;
    public List<Transform> transformList;


    public GameObject[] richtigeObjects;
    public GameObject[] speed;
    public GameObject[] cocos;
    public GameObject[] disco;
    public GameObject[] dolphys;
    public GameObject[] doppelkekse;
    public GameObject[] eisteeBlau;
    public GameObject[] eisteeGruen;
    public GameObject[] milch;
    public GameObject[] flyingPowerBlau;
    public GameObject[] flyingPowerRosa;
    public GameObject[] flyingPowerRot;
    public GameObject[] riverCola;
    public GameObject[] pizzaschiffchen;
    int randomObjekt;
    int randomAbwandlung;

    private void Awake()
    {
        RandomPos();
    }
    

    public void RandomPos()
    {
        richtigePos = Random.Range(0, transformList.Count);
        randomObjekt = Random.Range(0,11);
        Debug.Log(randomObjekt);
        randomAbwandlung = Random.Range(0, 6);
        
        
        if (randomObjekt == 0)
        {
            speed[randomAbwandlung].SetActive(true);
            Instantiate(speed[randomAbwandlung], transformList[richtigePos]);
        }
        if (randomObjekt == 1)
        {
            cocos[randomAbwandlung].SetActive(true);
            Instantiate(cocos[randomAbwandlung], transformList[richtigePos]);
        }
        if (randomObjekt == 2)
        {
            disco[randomAbwandlung].SetActive(true);
            Instantiate(disco[randomAbwandlung], transformList[richtigePos]);
        }
        if (randomObjekt == 3)
        {
            dolphys[randomAbwandlung].SetActive(true);
            Instantiate(dolphys[randomAbwandlung], transformList[richtigePos]);
        }
        if (randomObjekt == 4)
        {
            doppelkekse[randomAbwandlung].SetActive(true);
            Instantiate(doppelkekse[randomAbwandlung], transformList[richtigePos]);
        }
        if (randomObjekt == 5)
        {
            eisteeBlau[randomAbwandlung].SetActive(true);
            Instantiate(eisteeBlau[randomAbwandlung], transformList[richtigePos]);
        }
        if (randomObjekt == 6)
        {
            eisteeGruen[randomAbwandlung].SetActive(true);
            Instantiate(eisteeGruen[randomAbwandlung], transformList[richtigePos]);
        }
        if (randomObjekt == 7)
        {
            milch[randomAbwandlung].SetActive(true);
            Instantiate(milch[randomAbwandlung], transformList[richtigePos]);
        }
        if (randomObjekt == 8)
        {
            flyingPowerBlau[randomAbwandlung].SetActive(true);
            Instantiate(flyingPowerBlau[randomAbwandlung], transformList[richtigePos]);
        }
        if (randomObjekt == 9)
        {
            flyingPowerRosa[randomAbwandlung].SetActive(true);
            Instantiate(flyingPowerRosa[randomAbwandlung], transformList[richtigePos]);
        }
        if (randomObjekt == 10)
        {
            flyingPowerRot[randomAbwandlung].SetActive(true);
            Instantiate(flyingPowerRot[randomAbwandlung], transformList[richtigePos]);
        }
        if (randomObjekt == 11)
        {
            pizzaschiffchen[randomAbwandlung].SetActive(true);
            Instantiate(pizzaschiffchen[randomAbwandlung], transformList[richtigePos]);
        }
        
        
        for (int i = 0; i < transformList.Count; i++)
        {
            if (richtigePos != i)
            {
                Instantiate(richtigeObjects[randomObjekt], transformList[i]);
            }
        }
    }
    public void DestroyInstanzen()
    {
        for (int i = 0; i < transformList.Count; i++)
        {
            Destroy(transformList[i].GetChild(0).gameObject);
        }
        RandomPos();
    }
}
