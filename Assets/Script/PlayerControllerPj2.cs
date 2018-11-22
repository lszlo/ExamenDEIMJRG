using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerPj2 : MonoBehaviour {

    Rigidbody2D Jugador2;
    

    public int fuerzaMovimiento = 5;
    public float velocidadMaxima = 5;
    public float vel = 10;


    // Use this for initialization
    void Start()
    {
        Jugador2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {

            MoverDerecha();
        }
        if (Input.GetKey(KeyCode.W))
        {
            Arriba();
        }
        if (Input.GetKey(KeyCode.S))
        {
            Abajo();
        }

        if (Input.GetKey(KeyCode.A))
        {
            MoverIzquierda();
        }
    }


    void MoverDerecha()
    {
        if (Jugador2.velocity.x < velocidadMaxima)
        {
            Jugador2.AddForce(Vector2.right * fuerzaMovimiento);
        }

    }
    void MoverIzquierda()
    {
        if (Jugador2.velocity.x > -velocidadMaxima)
        {
            Jugador2.AddForce(Vector2.left * fuerzaMovimiento);
        }

    }
    void Arriba()
    {
       
       
            Jugador2.AddForce(Vector2.up * fuerzaMovimiento);
       

    }
    void Abajo()
    {
        if (Jugador2.velocity.y > -velocidadMaxima)
        {
            Jugador2.AddForce(Vector2.down * fuerzaMovimiento);
        }

    }
}
