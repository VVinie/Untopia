using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp = 10;
    public Transform point;
    public GameObject coin;

    public void Takedamage( int damage )
    {
        hp -= damage;

        if (hp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(coin, point.position, transform.rotation);
        Destroy(gameObject);
    }
}
