using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class ammo : MonoBehaviour
{
    public float speed;
    public float destroyTime;

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
}
