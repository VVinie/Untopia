using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Riflebulet : MonoBehaviour
{
    public float speed = 20;
    public float destroyTime = 10;
    public int damage = 3;

    void Start()
    {
        Invoke("DestroyAmmo", destroyTime);
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void DestroyAmmo()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D colision)
    {
        
            Enemy enemy = colision.GetComponent<Enemy>();

            if (enemy != null)
            {
                enemy.Takedamage(damage);
            }
            Destroy(gameObject);

    }
}
