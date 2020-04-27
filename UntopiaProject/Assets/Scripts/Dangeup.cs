using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Dangeup : MonoBehaviour
{
    public GameObject charecter;
    public GameObject dangeup;
    public GameObject dangefull;
    public GameObject dangewallstrans;
    public GameObject dangefull1;


    void Start()
    {
        dangeup.SetActive(true);
        dangefull.SetActive(false);
        dangefull1.SetActive(false);
        dangewallstrans.SetActive(true);
        charecter.GetComponent<SpriteRenderer>().sortingOrder = 3;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            dangeup.SetActive(false);
            dangefull.SetActive(true);
            dangefull1.SetActive(true);
            dangewallstrans.SetActive(false);
            charecter.GetComponent<SpriteRenderer>().sortingOrder = 5;

        }
    }
        void OnTriggerExit2D(Collider2D collision)
        {

            if (collision.gameObject.tag == "Player")
            {
                dangeup.SetActive(true);
                dangefull.SetActive(false);
                dangefull1.SetActive(false);
                dangewallstrans.SetActive(true);
                charecter.GetComponent<SpriteRenderer>().sortingOrder = 3;

            }

        }


}
