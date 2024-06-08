using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    float horizontal;
    public int speed;

    Vector2 movement;


    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        movement = new Vector2(horizontal, 0);

        transform.Translate(movement * Time.deltaTime * speed);
    }
}
