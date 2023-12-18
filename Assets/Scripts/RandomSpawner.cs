using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] objPrefab;
    //public bool stopSpawning;
    float spawnDelay = 2;
    float randomSpawnTime = 1;
    int zeitverschnaellerung = 5;
    bool cancelInvokeBool;
    public ProdukteAuffangen produkteAuffangen;
    float gravitySpeed = 2;
    List<GameObject> instanzen = new List<GameObject>();

    private void Start()
    {
        InvokeRepeating("RandomSpawn", randomSpawnTime, spawnDelay);
        for (int i = 0; i < objPrefab.Length - 1; i++)
        {

            Debug.Log(gravitySpeed);
            objPrefab[i].GetComponent<Rigidbody2D>().gravityScale = 2;
        }
    }
    private void Update()
    {
        if (produkteAuffangen.currentScore >= zeitverschnaellerung)
        {
            /*randomSpawnTime = randomSpawnTime * 2f;
            spawnDelay = spawnDelay * 0.5f;
            
            Debug.Log(randomSpawnTime);
            Debug.Log(spawnDelay);*/
            gravitySpeed = gravitySpeed * 1.5f;
            zeitverschnaellerung = zeitverschnaellerung + 5;
            for (int i = 0; i < objPrefab.Length -1; i++)
            {
                
                Debug.Log(gravitySpeed);
                objPrefab[i].GetComponent<Rigidbody2D>().gravityScale = gravitySpeed;
            }
        }
    }
    public void CancelInvokeL()
    {
        //CancelInvoke("RandomSpawn");
        cancelInvokeBool = true;
        Time.timeScale = 0;
        
    }
    public void DontCancelInvoke()
    {
        //InvokeRepeating("RandomSpawn", randomSpawnTime, spawnDelay);
        cancelInvokeBool = false;
        Time.timeScale = 1;
        /*for (int i = 0; i < objPrefab.Length; i++)
        {
            objPrefab[i].GetComponent<Rigidbody2D>().gravityScale = 1;
        }*/
    }

    public void RandomSpawn()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-2, 3), 7, 0);
        GameObject insTantiatObj = objPrefab[Random.Range(0, 19)];
        Instantiate(insTantiatObj, randomSpawnPosition, Quaternion.identity);
        instanzen.Add(insTantiatObj);
        //insTantiatObj.SetActive()
        if (cancelInvokeBool)
        {
            Debug.Log(GameObject.FindGameObjectsWithTag("HoferProdukte"));
            //insTantiatObj.SetActive(false);
            //insTantiatObj.GetComponent<Rigidbody2D>().enable = true;
        }
    }
}
