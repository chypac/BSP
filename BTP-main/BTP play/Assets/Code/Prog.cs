using UnityEngine;
using UnityEngine.UI;
using TMPro;
[System.Serializable]
public class PI
{
    public int Score;

}
public class Prog : MonoBehaviour
{
    public TextMeshProUGUI scoretxt;
    public PI pi;
    public static Prog Inst;

    private void Update()
    {
        if (scoretxt != null)

        { 
            scoretxt.text = "Score: " + Prog.Inst.pi.Score.ToString(); 
        }
    }
    private void Start()
    {
        
        if (Inst == null)   
        {
            transform.parent = null;
            Inst = this;
        }
    }
}
