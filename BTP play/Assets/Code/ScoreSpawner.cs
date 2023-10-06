
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnPoints;
    public float time;
    private void Start()
    {
        StartCoroutine(SpawnRandomPrefab());
    }

    private IEnumerator SpawnRandomPrefab()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            Vector3 spawnPosition = spawnPoints.position;

            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }
}