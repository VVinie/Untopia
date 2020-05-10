using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downtriger1 : MonoBehaviour
	
{
	public GameObject Upcolision;
	public GameObject Downcolision;
	public GameObject charecter;
	public GameObject undo;
	public GameObject pistol;
	public GameObject shootgun;
	public GameObject rifle;
	void Start()
		{
			
		Upcolision.SetActive(false);
	    Downcolision.SetActive(true);
		undo.SetActive(true);
		charecter.GetComponent<SpriteRenderer>().sortingOrder = 3;
		
		}
	void OnTriggerEnter2D(Collider2D collision)
    {
       
	   if (collision.gameObject.tag == "Player")
	   {
		   Upcolision.SetActive(false);
		   Downcolision.SetActive(true);
		   undo.SetActive(true);
		   charecter.GetComponent<SpriteRenderer>().sortingOrder = 3;
			pistol.GetComponent<SpriteRenderer>().sortingOrder = 3;
			shootgun.GetComponent<SpriteRenderer>().sortingOrder = 3;
			rifle.GetComponent<SpriteRenderer>().sortingOrder = 3;

		}

    }






}
