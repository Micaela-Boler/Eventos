using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogoNPC : MonoBehaviour
{
    void DialogoNpc(GameObject dialogo)
    {
       dialogo.SetActive(true);
    }


    private void OnEnable()
    {
        DialogoEvento.InterracionNPC += DialogoNpc;
    }


    private void OnDisable()
    {
        DialogoEvento.InterracionNPC -= DialogoNpc;
    }
}
