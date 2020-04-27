using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uptriger1 : MonoBehaviour
	
{
	public GameObject Upcolision;
	public GameObject Downcolision;
	public GameObject charecter;
	public GameObject undo;
	void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
		{
		   
		   Upcolision.SetActive(true);
		   Downcolision.SetActive(false);
		   undo.SetActive(false);
		   charecter.GetComponent<SpriteRenderer>().sortingOrder = 4;
		   
		   if (gameObject.tag == "Under")
		{
			
		}

	    }
		
    }






}
