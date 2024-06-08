using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public List<GameObject> listaObjetos;
    [SerializeField] Text textObjetos;
    int cantidadDeObjetos;


    void AñadirItem(GameObject objetoRecolectado)
    {
        listaObjetos.Add(objetoRecolectado);

        cantidadDeObjetos = listaObjetos.Count;
        textObjetos.text = "Objetos recolectados: " + cantidadDeObjetos;
    }


    private void OnEnable()
    {
        RecolectarObjetoEvento.ObjetoRecolectado += AñadirItem;
    }


    private void OnDisable()
    {
        RecolectarObjetoEvento.ObjetoRecolectado += AñadirItem;
    }
}
