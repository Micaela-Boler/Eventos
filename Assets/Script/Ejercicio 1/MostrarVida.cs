using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarVida : MonoBehaviour
{
    [SerializeField] Text SaludTexto;
    public int salud;


    void SaludDisplay(int cantidad)
    {
        salud = salud - cantidad;
        SaludTexto.text = "Salud: " + salud;
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
