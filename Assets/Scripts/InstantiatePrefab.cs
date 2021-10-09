using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePrefab : MonoBehaviour
{

    public GameObject wallsPrefab;
    private GameObject instantiatedWalls;
    private float nextSpawnTime;
    public float spawnDelay = 3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ShouldSpawn())
        {
            Spawn();
        }
        
    }

    private void Spawn()
    {
        nextSpawnTime = Time.time + spawnDelay;
        instantiatedWalls = (GameObject) Instantiate(wallsPrefab, new Vector3(transform.position.x, Random.Range(3, -3), transform.position.z), transform.rotation);
        Destroy(instantiatedWalls, 10f);
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }
}
