using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Scene : MonoBehaviour
{
    public TextMeshProUGUI txt;
    private int i = 0;
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
    public void IntPlus1()
    {
        i++;
        txt.text = i.ToString();
    }

}
