using UnityEngine;

public class TawerManager : MonoBehaviour//поставить башню находйась в тригере
{
    public Transform _tr;
    public GameObject[] _go;
    private bool flagTriger = true;
    public int[] price;
    
    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) && flagTriger)
            {
                if (Prog.Inst.pi.Score - price[0] >= 0)
                {
                    Prog.Inst.pi.Score -= price[0];
                    Vector3 transformPoint = _tr.position;
                    transformPoint.y += 0;

                    Instantiate(_go[0], transformPoint, Quaternion.identity);

                    flagTriger = false;
                    Destroy(this.gameObject);
                }
                else 
                {
                    Debug.Log("Not Score");
                }
                
            }
            if (Input.GetKeyDown(KeyCode.Alpha2) && flagTriger)
            {
                if (Prog.Inst.pi.Score - price[1] >= 0)
                {
                    Prog.Inst.pi.Score -= price[1];
                    Vector3 transformPoint = _tr.position;
                    transformPoint.y += 2.5f;

                    Instantiate(_go[1], transformPoint, Quaternion.identity);

                    flagTriger = false;
                    Destroy(this.gameObject);
                }
                else
                {
                    Debug.Log("Not Score");
                }
            }
        }
    }

}
