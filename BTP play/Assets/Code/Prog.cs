using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class PlayerInfo
{
    public int Score = 0;
    //public int Shtraf = -12;
}
public class Prog : MonoBehaviour
{
    public Text scoretxt;
    public PlayerInfo PlayerInfo;
    public static Prog Instance;

    private void Update()
    {
        scoretxt.text = "Score: " + Prog.Instance.PlayerInfo.Score.ToString();
        //scoretxt1.text = "fine: " + Prog.Instance.PlayerInfo.Shtraf.ToString();

    }
    private void Start()
    {
        if (Instance == null)
        {
            transform.parent = null;
            Instance = this;
        }
    }


}
