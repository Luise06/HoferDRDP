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
            objPrefab[i].GetComponent<Rigidbody2D>().gravityScale = 2;
        }
    }
    private void Update()
    {
        if (produkteAuffangen.currentScore >= zeitverschnaellerung)
        {
            gravitySpeed = gravitySpeed * 1.1f;
            zeitverschnaellerung = zeitverschnaellerung + 1;
            for (int i = 0; i < objPrefab.Length -1; i++)
            {
                Debug.Log("Gravity: "+ gravitySpeed);
                objPrefab[i].GetComponent<Rigidbody2D>().gravityScale = gravitySpeed;
            }
        }
    }
    

    public void RandomSpawn()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-2, 3), 7, 0);
        GameObject insTantiatObj = objPrefab[Random.Range(0, objPrefab.Length-1)];
        Instantiate(insTantiatObj, randomSpawnPosition, Quaternion.identity);
        instanzen.Add(insTantiatObj);
    }
}
