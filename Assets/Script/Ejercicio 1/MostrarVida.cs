using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarVida : MonoBehaviour
{
    [SerializeField] Text SaludTexto;
    public int Salud;


    void SaludDisplay(int cantidad)
    {
        Salud = Salud - cantidad;
        SaludTexto.text = "Salud: " + Salud;
    }


    private void OnEnable()
    {
       VidaDeJugador.CambioSaludEvento += SaludDisplay;
    }


    private void OnDisable()
    {
       VidaDeJugador.CambioSaludEvento -= SaludDisplay;
    }
}
