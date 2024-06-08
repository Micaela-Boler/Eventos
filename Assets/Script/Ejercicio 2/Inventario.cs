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


    void A�adirItem(GameObject objetoRecolectado)
    {
        listaObjetos.Add(objetoRecolectado);

        cantidadDeObjetos = listaObjetos.Count;
        textObjetos.text = "Objetos recolectados: " + cantidadDeObjetos;
    }


    private void OnEnable()
    {
        RecolectarObjetoEvento.ObjetoRecolectado += A�adirItem;
    }


    private void OnDisable()
    {
        RecolectarObjetoEvento.ObjetoRecolectado += A�adirItem;
    }
}
