using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] public int intScore;//дефауло 0\ъ
    public int score =10;
    private float time = 1;
    private void Start()
    {
        ObCur1(score);
        StartCoroutine(ObCur(score));

    }
    private IEnumerator ObCur(int score)
    {
        while (true)
        { 
            yield return new WaitForSeconds(time);
            score++;
            Debug.Log(score);
        }
    }
    private void ObCur1(int score)
    {
        
            score++;
        
    }
}
