using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class IntefazEstadoDejuego : MonoBehaviour
{
    [SerializeField] GameObject menuPausa;


    private void Start()
    {
        menuPausa.SetActive(false);
    }


    void ActivarMenuDePausa(int cantidad)
    {
        switch (cantidad)
        {
            case 0: menuPausa.SetActive(true); 
                break;

            case 1: menuPausa.SetActive(false); 
                break;
        }
    }

    private void OnEnable()
    {
        EstadoDeJuegoEvento.EstadoDeJuego += ActivarMenuDePausa;
    }

    private void OnDisable()
    {
        EstadoDeJuegoEvento.EstadoDeJuego -= ActivarMenuDePausa;
    }
}
