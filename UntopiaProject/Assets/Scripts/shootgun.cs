using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class shootgun : MonoBehaviour
{
    public float offset;
    public GameObject camera;
    public GameObject ammo;
    public Transform shotDir;
    private float timeShot;
    public float startTime;
    public int currentAmmo = 5;
    public int allAmmo = 0;
    public int fullAmmo = 32;
    public GameObject ammoPistol;
    public pistol pistol;
    
    [SerializeField]
    public Text ammoCount;



    void Start()
    {
        camera.SetActive(true);
        ammoCount.text = currentAmmo + "  /  " + allAmmo;
    }

    
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);

        if (timeShot <= 0)
        {
            if (Input.GetMouseButtonDown(0) && currentAmmo > 0)
            { 
                Instantiate(ammo, shotDir.position, transform.rotation);
                timeShot = startTime;
                currentAmmo -= 1;
            }
        }
        else
        {
            timeShot -= Time.deltaTime; 
        }

        ammoCount.text = currentAmmo + "  /  " + allAmmo;
        pistol.ammoCount.text = pistol.currentAmmo + "  /  " + pistol.allAmmo;

        if (Input.GetKeyDown(KeyCode.R) && allAmmo > 0)
        {
            StartCoroutine(Reload());
        }
    }
    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.GetComponent<Shootgunammo>())
        {
            allAmmo += 10;
            Destroy(colision.gameObject);
        }
        else if (colision.GetComponent<Pistolammo>())
        {
            pistol.allAmmo += 14;
            Destroy(colision.gameObject);
        }
    }

    public IEnumerator Reload()
    {
       int reason = 5 - currentAmmo;
        if (allAmmo >= reason)
        {
            for (int i = 0; i < reason; i++)
            {
                yield return new WaitForSeconds(1);
                currentAmmo += 1;
                allAmmo -= 1;
            }
        }
        else
        {
            for (int i = 0; i < allAmmo; i++)
            {
                yield return new WaitForSeconds(1);
                currentAmmo += 1;
                allAmmo -= 1;
            }
        }

    }
}
