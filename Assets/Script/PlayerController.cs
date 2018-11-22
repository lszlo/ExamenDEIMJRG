using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour { 
    Rigidbody2D Jugador1;
   
    public int fuerzaMovimiento = 5;
    public int fuerzaSalto = 5;
    public float velocidadMaxima = 5;
    public float vel = 10;
  

    // Use this for initialization
    void Start () {
        Jugador1 = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {

            MoverDerecha();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Arriba();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Abajo();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoverIzquierda();
        }
    }


    void MoverDerecha()
    {
        if (Jugador1.velocity.x < velocidadMaxima)
        {
            Jugador1.AddForce(Vector2.right * fuerzaMovimiento);
        }
        
    }
    void MoverIzquierda()
    {
        if (Jugador1.velocity.x > -velocidadMaxima)
        {
           Jugador1.AddForce(Vector2.left * fuerzaMovimiento);
        }
       
    }
    void Arriba()
    { 
       
             Jugador1.AddForce(Vector2.up* fuerzaMovimiento);
           

    }
    void Abajo()
    {
        if (Jugador1.velocity.y > -velocidadMaxima)
        {
            Jugador1.AddForce(Vector2.down * fuerzaMovimiento);
        }

    }
}
