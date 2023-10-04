using System.Collections;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject[] prefab;
    public Transform[] spawnPoints;

    private void Start()
    {
        StartCoroutine(SpawnRandomPrefab());
    }

    private IEnumerator SpawnRandomPrefab()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);

            int randomSpawnPointIndex = Random.Range(0, spawnPoints.Length);
            int randomSpawnprefab = Random.Range(0, prefab.Length);

            Vector3 spawnPosition = spawnPoints[randomSpawnPointIndex].position;
            spawnPosition.z = 0;
            Instantiate(prefab[randomSpawnprefab], spawnPosition, Quaternion.identity);
        }
    }
}