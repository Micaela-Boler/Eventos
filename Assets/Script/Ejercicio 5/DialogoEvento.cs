using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoEvento : MonoBehaviour
{
    public static event Action<GameObject> InterracionNPC;
    [SerializeField] GameObject dialogo;


    private void Start()
    {
        dialogo.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Jugador"))
            InterracionNPC?.Invoke(dialogo);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Jugador"))
            dialogo.SetActive(false);
    }
}
