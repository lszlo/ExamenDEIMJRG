using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour {
    public Text textoContador1;
    
    public int limitePuntos = 5;
    public int puntos = 0;
    // Use this for initialization
    void Start ()
    {
        textoContador1.text = puntos.ToString();
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D porteria)
    {
        if (puntos < limitePuntos)
        {
            if (porteria.gameObject.CompareTag("Pelota"))
            {
                puntos++;
                textoContador1.text = puntos.ToString();
            
            } 
           

        }
        
    }
}
