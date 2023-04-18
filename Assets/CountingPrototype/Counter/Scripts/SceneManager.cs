using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float numToSpawn;
    public float minRange;
    public float maxRange;



    // Start is called before the first frame update
    void Start()
    {

        while(numToSpawn > 0) {
            Instantiate(prefabToSpawn, new Vector3(Random.Range(minRange, maxRange), (Random.Range(minRange, maxRange) + 15), Random.Range(minRange, maxRange)), Quaternion.identity);
            numToSpawn--;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
