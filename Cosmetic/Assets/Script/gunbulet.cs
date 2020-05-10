using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using Microsoft.Win32;

public class gunbulet : MonoBehaviour
{
    public float speed;
    public float destroyTime;
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
        
            enym enym = colision.GetComponent<enym>();

            if (enym != null)
            {
                enym.Takedamage(damage);
            }
            Destroy(gameObject);

    }
}
