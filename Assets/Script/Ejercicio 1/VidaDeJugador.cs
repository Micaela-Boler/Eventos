using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDeJugador : MonoBehaviour
{
    public static event Action<int> CambioSaludEvento;


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
            CambioSaludEvento?.Invoke(1);
    }
}
