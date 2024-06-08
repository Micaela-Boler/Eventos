using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolectarObjetoEvento : MonoBehaviour
{
    public static event Action<GameObject> ObjetoRecolectado;
    [SerializeField] GameObject objeto;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Jugador"))
        {
            ObjetoRecolectado?.Invoke(objeto);
            Destroy(gameObject);
        }

        //cambiar action por un evento comun y luego añadir al trigger el metodo "añadirItem"
    }
}
