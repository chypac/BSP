using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed;
    //public GameObject impactEffect;
    public float damageAmount;
    void Start()
    {
        rb.velocity = transform.forward * moveSpeed;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Enemy")
        {
            other.GetComponent<EnemyHeaphController>().TakeDamage(damageAmount);
        }
        //Instantiate(impactEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
