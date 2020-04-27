using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class dangelogical : MonoBehaviour
{
    public GameObject door;
    void Start()
    {
        door.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
            door.SetActive(false);
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        door.SetActive(true);
    }
}
