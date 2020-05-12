using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public IsometricPlayerMovementController control;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        control.money += 10;
        Destroy(gameObject);
    }
}
