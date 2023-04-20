using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMan : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float numToSpawn;
    public float minRange;
    public float maxRange;



    // Start is called before the first frame update
    void Start()
    {

        while(numToSpawn > 0) {
            Instantiate(prefabToSpawn, new Vector3(UnityEngine.Random.Range(minRange, maxRange), (UnityEngine.Random.Range(minRange, maxRange) + 15), UnityEngine.Random.Range(minRange, maxRange)), Quaternion.identity);
            numToSpawn--;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
