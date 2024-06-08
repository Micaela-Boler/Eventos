using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoDeJuegoEvento : MonoBehaviour
{
    public static event Action<int> EstadoDeJuego;


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            Time.timeScale = 0;
            EstadoDeJuego?.Invoke(0);
        }

        else if (Input.GetKeyUp(KeyCode.Escape))
        {
            Time.timeScale = 1;
            EstadoDeJuego?.Invoke(1);
        }
    }
}
