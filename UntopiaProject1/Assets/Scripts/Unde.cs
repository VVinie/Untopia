using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unde : MonoBehaviour
{
  public GameObject Spritemask;
  public GameObject Spritemask1;
  
    void Start()
    {
		Spritemask.SetActive(false);
		Spritemask1.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
		
		Spritemask.SetActive(true);
		Spritemask1.SetActive(true);
		
    }
	void OnTriggerExit2D(Collider2D collision)
    {

		Spritemask.SetActive(false);
		Spritemask1.SetActive(false);
		
    }
	
}
