using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downtriger1 : MonoBehaviour
	
{
	public GameObject Upcolision;
	public GameObject Downcolision;
	public GameObject charecter;
	public GameObject undo;
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
		   
	   }

    }






}
