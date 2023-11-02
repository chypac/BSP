using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 10f;  // Скорость движения пули
    private Transform target;     // Цель (враг), к которой пуля движется
    public float damageAmount = 10;
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    void Update()
    {
        if (target != null)
        {
            // Направляем пулю к цели
            Vector3 direction = (target.position - transform.position).normalized;
            transform.Translate(direction * moveSpeed * Time.deltaTime, Space.World);
        }
        else
        {
            // Если цель отсутствует, уничтожаем пулю
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<EnemyHeaphController>().TakeDamage(damageAmount);
            Destroy(this.gameObject);
        }
    }
}
