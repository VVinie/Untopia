using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class pistol : MonoBehaviour
{
    public float offset;
    public GameObject camera;
    public GameObject ammo;
    public Transform shotDir;
    private float timeShot;
    public float startTime;
    public int currentAmmo = 7;
    public int allAmmo = 0;
    public int fullAmmo = 64;
    public GameObject ammoShootgun;
    public shootgun shootgun;

    [SerializeField]
    public Text ammoCount;



    void Start()
    {
        camera.SetActive(true);
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
        shootgun.ammoCount.text = shootgun.currentAmmo + "  /  " + shootgun.allAmmo;

        if (Input.GetKeyDown(KeyCode.R) && allAmmo > 0)
        {
            Invoke("Reload", 2f);
        }
    }
    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.GetComponent<Pistolammo>())
        {
            allAmmo += 14;
            Destroy(colision.gameObject);
        }
        else if (colision.GetComponent<Shootgunammo>())
        {
            shootgun.allAmmo += 10;
            Destroy(colision.gameObject);
        }
    }

    public void Reload()
    {
        int reason = 7 - currentAmmo;
        if (allAmmo >= reason)
        {
            allAmmo = allAmmo - reason;
            currentAmmo = 7;
        }
        else
        {
            currentAmmo = currentAmmo + allAmmo;
            allAmmo = 0;
        }
    }
}
