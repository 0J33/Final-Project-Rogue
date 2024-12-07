using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 5;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed; // Propel the arrow forward
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Minion") || (other.CompareTag("Demon")) || (other.CompareTag("Lilith")))
        {
            EnemyController enemy = other.GetComponent<EnemyController>();
            if (enemy != null)
            {
                enemy.Damage(5); // Deal damage to the enemy
            }
        }

        if (other.CompareTag("Wanderer"))
        {
            // Don't destroy arrow
        } else
        {
            Destroy(gameObject); // Destroy the arrow on impact
        }

    }

}
