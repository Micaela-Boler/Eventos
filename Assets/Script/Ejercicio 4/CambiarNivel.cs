using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarNivel : MonoBehaviour
{

    void CambiarInformacion(int nivel)
    {
       SceneManager.LoadScene(nivel);
    }


    private void OnEnable()
    {
        NivelEvento.CambiarNivel += CambiarInformacion;
    }


    private void OnDisable()
    {
        NivelEvento.CambiarNivel -= CambiarInformacion;
    }
}
