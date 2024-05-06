using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionRan : MonoBehaviour
{
    int richtigePos;
    public List<Transform> transformList;


    public GameObject[] richtigeObjects;
    //public int[] randomArray;
    public GameObject[] speed;
    public GameObject[] cocos;
    public GameObject[] disco;
    public GameObject[] dolphys;
    public GameObject[] doppelkekse;
    public GameObject[] eisteeBlau;
    public GameObject[] eisteeGruen;
    /*public GameObject[] milch;
    public GameObject[] flyingPowerBlau;
    public GameObject[] flyingPowerRosa;
    public GameObject[] flyingPowerRot;*/
    public GameObject[] pizzaschiffchen;
    public GameObject[] riverCola;
    int randomObjekt;
    int randomAbwandlung;

    //public RandomPosition randomPosition;

    private void Awake()
    {
        //RandomArrayausWahl();
        RandomPos();
    }
    /*public void RandomArrayausWahl()
    {
        randomObjekt = Random.Range(0, 7);
        randomAbwandlung = Random.Range(0, 6);
        if (randomObjekt == 0)
        {
            speed[randomAbwandlung].SetActive(true);
            Instantiate(speed[randomAbwandlung], randomPosition.spawnPoints[randomPosition.randomPosition]);
        }
        if (randomObjekt == 1)
        {
            cocos[randomAbwandlung].SetActive(true);
            Instantiate(cocos[randomAbwandlung], randomPosition.spawnPoints[randomPosition.randomPosition]);
        }
        if (randomObjekt == 2)
        {
            disco[randomAbwandlung].SetActive(true);
            Instantiate(disco[randomAbwandlung], randomPosition.spawnPoints[randomPosition.randomPosition]);
        }
        /*if (randomObjekt == 3)
        {
            dolphys[randomAbwandlung].SetActive(true);
            Instantiate(dolphys[randomAbwandlung], randomPosition.spawnPoints[randomPosition.randomPosition]);
        }
        if (randomObjekt == 4)
        {
            doppelkekse[randomAbwandlung].SetActive(true);
            Instantiate(doppelkekse[randomAbwandlung], randomPosition.spawnPoints[randomPosition.randomPosition]);
        }
        if (randomObjekt == 5)
        {
            eisteeBlau[randomAbwandlung].SetActive(true);
            Instantiate(eisteeBlau[randomAbwandlung], randomPosition.spawnPoints[randomPosition.randomPosition]);
        }
        if (randomObjekt == 6)
        {
            eisteeGruen[randomAbwandlung].SetActive(true);
            Instantiate(eisteeGruen[randomAbwandlung], randomPosition.spawnPoints[randomPosition.randomPosition]);
        }
        /*if (randomObjekt == 7)
        {
            milch[randomAbwandlung].SetActive(true);
            Instantiate(milch[randomAbwandlung], randomPosition.spawnPoints[randomPosition.randomPosition]);
        }
        if (randomObjekt == 8)
        {
            flyingPowerBlau[randomAbwandlung].SetActive(true);
            Instantiate(flyingPowerBlau[randomAbwandlung], randomPosition.spawnPoints[randomPosition.randomPosition]);
        }
        if (randomObjekt == 9)
        {
            flyingPowerRosa[randomAbwandlung].SetActive(true);
            Instantiate(flyingPowerRosa[randomAbwandlung], randomPosition.spawnPoints[randomPosition.randomPosition]);
        }
        if (randomObjekt == 10)
        {
            flyingPowerRot[randomAbwandlung].SetActive(true);
            Instantiate(flyingPowerRot[randomAbwandlung], randomPosition.spawnPoints[randomPosition.randomPosition]);
        }
        if (randomObjekt == 7)
        {
            pizzaschiffchen[randomAbwandlung].SetActive(true);
            Instantiate(pizzaschiffchen[randomAbwandlung], randomPosition.spawnPoints[randomPosition.randomPosition]);
        }

    }*/

    public void RandomPos()
    {
        randomObjekt = Random.Range(0, 7);
        randomAbwandlung = Random.Range(0, 6);
        richtigePos = Random.Range(0, transformList.Count);
        Debug.Log("objekt: " + randomObjekt);
        Debug.Log(richtigePos);
        Instantiate(richtigeObjects[randomObjekt], transformList[richtigePos]);
        
        for (int i = 0; i < transformList.Count; i++)
        {
            if (richtigePos != i)
            {
                
                if (randomObjekt == 0)
                {
                    speed[randomAbwandlung].SetActive(true);
                    Instantiate(speed[randomAbwandlung], transformList[i]);
                }
                if (randomObjekt == 1)
                {
                    cocos[randomAbwandlung].SetActive(true);
                    Instantiate(cocos[randomAbwandlung], transformList[i]);
                }
                if (randomObjekt == 2)
                {
                    disco[randomAbwandlung].SetActive(true);
                    Instantiate(disco[randomAbwandlung], transformList[i]);
                }
                if (randomObjekt == 3)
                {
                    dolphys[randomAbwandlung].SetActive(true);
                    Instantiate(dolphys[randomAbwandlung], transformList[i]);
                }
                if (randomObjekt == 4)
                {
                    doppelkekse[randomAbwandlung].SetActive(true);
                    Instantiate(doppelkekse[randomAbwandlung], transformList[i]);
                }
                if (randomObjekt == 5)
                {
                    eisteeBlau[randomAbwandlung].SetActive(true);
                    Instantiate(eisteeBlau[randomAbwandlung], transformList[i]);
                }
                if (randomObjekt == 6)
                {
                    eisteeGruen[randomAbwandlung].SetActive(true);
                    Instantiate(eisteeGruen[randomAbwandlung], transformList[i]);
                }
                /*if (randomObjekt == 7)
                {
                    milch[randomAbwandlung].SetActive(true);
                    Instantiate(milch[randomAbwandlung], randomPosition.spawnPoints[randomPosition.randomPosition]);
                }
                if (randomObjekt == 8)
                {
                    flyingPowerBlau[randomAbwandlung].SetActive(true);
                    Instantiate(flyingPowerBlau[randomAbwandlung], randomPosition.spawnPoints[randomPosition.randomPosition]);
                }
                if (randomObjekt == 9)
                {
                    flyingPowerRosa[randomAbwandlung].SetActive(true);
                    Instantiate(flyingPowerRosa[randomAbwandlung], randomPosition.spawnPoints[randomPosition.randomPosition]);
                }
                if (randomObjekt == 10)
                {
                    flyingPowerRot[randomAbwandlung].SetActive(true);
                    Instantiate(flyingPowerRot[randomAbwandlung], randomPosition.spawnPoints[randomPosition.randomPosition]);
                }*/
                if (randomObjekt == 7)
                {
                    pizzaschiffchen[randomAbwandlung].SetActive(true);
                    Instantiate(pizzaschiffchen[randomAbwandlung], transformList[i]);
                }

            }
        }
    }
}
