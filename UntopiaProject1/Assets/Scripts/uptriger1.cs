using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uptriger1 : MonoBehaviour
	
{
	public GameObject Upcolision;
	public GameObject Downcolision;
	public GameObject charecter;
	public GameObject undo;
	public GameObject pistol;
	public GameObject rifle;
	public GameObject shootgun;
	void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
		{
		   
		   Upcolision.SetActive(true);
		   Downcolision.SetActive(false);
		   undo.SetActive(false);
		   charecter.GetComponent<SpriteRenderer>().sortingOrder = 4;
			pistol.GetComponent<SpriteRenderer>().sortingOrder = 4;
			rifle.GetComponent<SpriteRenderer>().sortingOrder = 4;
			shootgun.GetComponent<SpriteRenderer>().sortingOrder = 4;

		}
		
    }






}
