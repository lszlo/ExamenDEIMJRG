using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pcNave : MonoBehaviour {

    Rigidbody2D Jugador1;

    public int fuerzaMovimiento = 5;
    public int fuerzaSalto = 5;
    public float velocidadMaxima = 5;
    public float vel = 10;
    public GameObject particulas;
    


    // Use this for initialization
    void Start()
    {
        Jugador1 = GetComponent<Rigidbody2D>();
        
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

        Jugador1.AddForce(Vector2.up * fuerzaMovimiento);


    }
    void Abajo()
    {
        if (Jugador1.velocity.y > -velocidadMaxima)
        {
            Jugador1.AddForce(Vector2.down * fuerzaMovimiento);
        }

    }
    void OnTriggerEnter2D(Collider2D col)
    {
       
       if (col.gameObject.CompareTag("terreno"))
       { 
                Destroy(gameObject);
                GeneraExplosion();

        }
    }
    void GeneraExplosion()
    {
        GameObject particula;
        particula = Instantiate(particulas, transform.position,transform.rotation);
        particula.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-200, 200), 200));
    }
}



