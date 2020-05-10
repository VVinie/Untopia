using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Microsoft.Win32;

public class control : MonoBehaviour
{
   public float acceleration;
   public Rigidbody2D rb;
   public float offset;
   public GameObject camera;
   public GameObject button;
   public int killse = 0;
   public int health = 100;
   [SerializeField]
    public Text kills;
	public float speed;

    
	void Start(){kills.text = "kills:  " + killse;}
	
	void FixedUpdate()
    {
		
		Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);
		
		rb.AddForce(difference.normalized * acceleration);
		
		if (health <= 0)
		{
			button.SetActive(true);
			Destroy(gameObject);
		}
						
    }
	
	private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.GetComponent<enym>())
        {
            health -= 1;
        }
    }
	
	public void killss()
	{
		killse = killse += 1;
		kills.text = "kills:  " + killse;
	}
	
	void Awake(){killse = 0;}
	
}
