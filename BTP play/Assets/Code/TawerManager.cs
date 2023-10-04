using UnityEngine;

public class TawerManager : MonoBehaviour//поставить башню находйась в тригере
{
    public Transform _tr;
    public GameObject _go;
    private bool flagTriger = true;

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) && flagTriger)
            {
                Vector3 transformPoint = _tr.position;
                transformPoint.y += 2;

                Instantiate(_go, transformPoint, Quaternion.identity);

                flagTriger = false;
                Destroy(this.gameObject);
            }
        }
    }
}
