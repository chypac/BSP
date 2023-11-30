
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSpawner : soundctl
{
    public float time = 1;
    private void Start()
    {
        StartCoroutine(SpawnRandomPrefab());
        PlaySound(sounds[1]);
    }

    private IEnumerator SpawnRandomPrefab()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            Prog.Inst.pi.Score++;
        }
    }
}