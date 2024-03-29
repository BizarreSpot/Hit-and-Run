using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sistema_Juego : MonoBehaviour
{
    public Player Juego;

    public Button btnReload;
    public Button btnLevel;
    public Button Repetir_Nivel;
    public Text txtpuntos;

    public int puntos_Max;


    public int puntos;
    void Start()
    {
        puntos = 0;
        btnLevel.gameObject.SetActive(false);
        btnReload.gameObject.SetActive(false);
        Repetir_Nivel.gameObject.SetActive(false);
    }


    void Update()
    {


        if (Juego.perdiste)
        { 
            if ( puntos == puntos_Max)
            {
                Repetir_Nivel.gameObject.SetActive(true);
                btnReload.gameObject.SetActive(false);
            }
            if (puntos <= puntos_Max-1) 
            { 
                btnReload.gameObject.SetActive(true);
                Repetir_Nivel.gameObject.SetActive(false);
            }
        }
        else if (!Juego.perdiste)
        {
            btnReload.gameObject.SetActive(false);
            Repetir_Nivel.gameObject.SetActive(false);
        }

    }
}

