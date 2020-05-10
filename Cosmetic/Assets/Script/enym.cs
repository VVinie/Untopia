using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;
using System.Collections.Generic;

public class enym : MonoBehaviour
{
    public int hp = 10;
	
	public GameObject ammo;
	public Transform ammospawn;
	public Transform ship;
	public control control;
	public Rigidbody2D rb;
	public float offset;
	public float acceleration;

    void FixedUpdate()
    {
		
		Vector3 difference = ship.position - transform.position;
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);
		
		rb.AddForce(difference.normalized * acceleration);
    }
	
	public void Takedamage( int damage )
    {
        hp = hp -= damage;

        if (hp <= 0)
        {
			Die();
        }
    }

    public void Die()
    {
            
			Instantiate(ammo, ammospawn.position, transform.rotation);
			control.killss();
			Destroy(gameObject);
		
    }
}
