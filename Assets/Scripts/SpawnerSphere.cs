using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class SpawnerBola : MonoBehaviour
{
    public GameObject spherePrefab;
    public float minSpawnDelay = 1;
    public float maxSpawnDelay = 3;
    public List<Transform> spawnPoints = new List<Transform>();


    IEnumerator SpawnSphereDelay()
    {
        while (true)
        {
            Transform currentPoint = spawnPoints[Random.Range(0, spawnPoints.Count)];
            Transform currentsphere = LeanPool.Spawn(spherePrefab).transform;
            currentsphere.eulerAngles = new Vector3(0, -90, 0);
            currentsphere.position = currentPoint.position;
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
        }
    }

    private void Start()
    {
        StartCoroutine(SpawnSphereDelay());
    }

}