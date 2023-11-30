using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHeaphController : MonoBehaviour// ХП ВРАГА
{
    public float totalHealth;

    public GameObject cubePrefab;
    public float explodeForce;
    private void Die()
    {
        for (int x = 0; x < 4; x++)
        {
            for (int y = 0; y < 4; y++)
            {
                for (int z = 0; z < 4; z++)
                {
                    Vector3 piecePosition = transform.position + new Vector3(x, y, z) * 0.5f;
                    GameObject piece = Instantiate(cubePrefab, piecePosition, Quaternion.identity);
                    Rigidbody pieceRigidbody = piece.GetComponent<Rigidbody>();
                    pieceRigidbody.AddExplosionForce(explodeForce, transform.position, 5f);
                    Destroy(piece, 2f);     
                }
            }
        }
        Destroy(this.transform.gameObject);
    }
    public void TakeDamage(float damageAmount)
    {
        totalHealth -= damageAmount;
        if(totalHealth <= 0)
        {
            Die();
        }      
    }
}
