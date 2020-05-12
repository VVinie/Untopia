using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trader : MonoBehaviour
{
    public Transform prefab;
    public Transform parent;
    public GameObject youhaverifle;
    public IsometricPlayerMovementController control;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E) && control.money >= 10)
        {
            control.money -= 10;
            var child = Instantiate(prefab, parent);
            Texte();

        }
    }

    public IEnumerator Texte()
    {
        youhaverifle.SetActive(true);
        yield return new WaitForSeconds(2);
        youhaverifle.SetActive(false);

    }
}
