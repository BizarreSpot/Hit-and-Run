﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rafita : MonoBehaviour
{

    private AudioSource audios;
    [SerializeField] private AudioClip danger;

    public Sistema_Juego juego;
    public Ragdolls rafita_Ragdoll;
    public GameObject Collider_Puntos;
    void Start()
    {
        
    }


    void Update()
    {
     juego.txtpuntos.text = juego.puntos_Max + "/" + juego.puntos.ToString(); ;
    }

    void OnTriggerEnter(Collider obj)
    {

        if (obj.gameObject.tag == "Jugador")
        {
            rafita_Ragdoll.colicion_Rafita = true;
            Collider_Puntos.SetActive(false);
            juego.puntos++;
            juego.txtpuntos.text = juego.puntos_Max + "/" + juego.puntos.ToString();
            audios.PlayOneShot(danger);

        }

        if (juego.puntos >= juego.puntos_Max)
        {
 juego.Regresa.gameObject.SetActive(true);
        }
    }
}
