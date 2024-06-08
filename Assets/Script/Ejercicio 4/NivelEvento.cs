using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelEvento : MonoBehaviour
{
    public static event Action<int> CambiarNivel;
    [SerializeField] int nivel;



    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            CambiarNivel?.Invoke(nivel);
        }
    }
}
