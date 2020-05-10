using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enym;
    public Transform spawnere;
	
	void Start()
    {
        Instantiate(enym, spawnere.position, transform.rotation);
    }

    void Update()
    {
        
    }
}
