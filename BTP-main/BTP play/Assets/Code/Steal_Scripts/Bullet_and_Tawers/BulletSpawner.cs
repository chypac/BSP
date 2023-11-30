using UnityEngine;

public class BulletSpawner : soundctl
{
    public GameObject bulletPrefab;     // Префаб пули
    public Transform bulletSpawnPoint;  // Место, откуда будет выстрел
    public float timeBetweenSpawn = 1.0f;
    public Transform launcherModel;
    

    private float shotCounter;
    private Tower theTower;
    private Transform target;

    void Start()
    {
        theTower = GetComponent<Tower>();
    }

    void Update()
    {
        shotCounter -= Time.deltaTime;

        if (target != null)
        {
            launcherModel.rotation =
                Quaternion.Slerp(launcherModel.rotation, Quaternion.LookRotation(target.position - transform.position), 4.0f * Time.deltaTime);
            launcherModel.rotation = Quaternion.Euler(0f, launcherModel.rotation.eulerAngles.y, 0f);
        }

        if (shotCounter <= 0 && target != null)
        {
            shotCounter = timeBetweenSpawn;
            bulletSpawnPoint.LookAt(target);

            // Создаем новую пулю и передаем ей цель
            GameObject newBullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            Bullet bulletComponent = newBullet.GetComponent<Bullet>();
            PlaySound(sounds[1]);
            if (bulletComponent != null)
            {
                bulletComponent.SetTarget(target);
            }
        }

        if (theTower.enemiesInRange.Count > 0)
        {
            float minDistance = theTower.range + 1f;
            bool isTargetInRange = false;
            foreach (EnemyController enemy in theTower.enemiesInRange)
            {
                if (enemy != null)
                {
                    float distance = Vector3.Distance(transform.position, enemy.transform.position);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        target = enemy.transform;
                        isTargetInRange = true;
                    }
                }
            }

            if (!isTargetInRange)
            {
                target = null;
            }
        }
        else
        {
            target = null;
        }
    }
}