using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sistema_Juego : MonoBehaviour
{
    public Player Juego;

    public GameObject Pantalla_Ganar;
    public GameObject Pantalla_Perder;

    public Button btnReload;
    public Button Repetir_Nivel;
    public Text Regresa;
    public Text txtpuntos;

    public float reloj;
    public Text txtTiempo;

    public int puntos_Max;

    public bool ganar = false;
    public int puntos;

    public bool menus = false;
    public float tiempo_delta;
    void Start()
    {
        puntos = 0;
        btnReload.gameObject.SetActive(false);
        Repetir_Nivel.gameObject.SetActive(false);
        Pantalla_Ganar.SetActive(false);
        Pantalla_Perder.SetActive(false);
        Regresa.gameObject.SetActive(false);
        tiempo_delta = 1;
}


    void Update()
    {
        if (menus == true)
        {
            Pantalla_Ganar.SetActive(true);
        }

        reloj -= Time.deltaTime * tiempo_delta;
            if (reloj <= 0f)
            {
                reloj = 0.0f;
                Juego.perdiste = true;

            }

            txtTiempo.text = "Tiempo: " + reloj.ToString("F2");

            if (Juego.perdiste)
            {
            Regresa.gameObject.SetActive(false);

            if (reloj <= 0f)
                {
                    Pantalla_Perder.SetActive(true);
                    Repetir_Nivel.gameObject.SetActive(true);
                    btnReload.gameObject.SetActive(false);
                }
                else if (puntos == puntos_Max)
                {
                    Pantalla_Perder.SetActive(true);
                    tiempo_delta = 0;
                    Repetir_Nivel.gameObject.SetActive(true);
                    btnReload.gameObject.SetActive(false);
                }
                else if (puntos <= puntos_Max - 1)
                {
  
                    btnReload.gameObject.SetActive(true);
                    Repetir_Nivel.gameObject.SetActive(false);
                }
            }
            else if (!Juego.perdiste && reloj >= 0f)
            {
            Pantalla_Perder.SetActive(false);
            btnReload.gameObject.SetActive(false);
                Repetir_Nivel.gameObject.SetActive(false);

                if (puntos == puntos_Max)
                {
                    ganar = true;
                }

            }
        }
    }


