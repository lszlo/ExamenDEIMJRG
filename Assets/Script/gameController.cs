﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour {
    public Animator animacionInterface;
    public bool pausa = false;
   

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausa = !pausa;
            animacionInterface.SetBool("visible", pausa);
        }
        if (pausa)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
    //poner el scene manager ese arriba UwU 
    public void RecargaNivel()
    {
        SceneManager.LoadScene("Nave");
    }
}
