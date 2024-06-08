using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelEvento : MonoBehaviour
{
    public static event Action<int> CambiarNivel;

    public Inventario inventario;
    public MostrarVida mostrarVida;


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            CambiarNivel?.Invoke(0);
        }
    }

    //acceder a la varibable de salud y de objetos recolectados, luego hacer que se reinicnien
}
