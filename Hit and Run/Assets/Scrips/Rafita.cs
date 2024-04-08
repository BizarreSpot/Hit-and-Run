using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rafita : MonoBehaviour
{
    private AudioSource audioRafa;
    [SerializeField] private AudioClip rafa;


    public Sistema_Juego juego;
    public Ragdolls rafita_Ragdoll;
    public GameObject Collider_Puntos;

    void Start()
    {
        audioRafa = GetComponent<AudioSource>();

    }


    void Update()
    {

        juego.txtpuntos.text = juego.puntos_Max + "/" + juego.puntos.ToString(); ;
    }

    void OnTriggerEnter(Collider obj)
    {

        if (obj.gameObject.tag == "Jugador")
        {

            audioRafa.PlayOneShot(rafa);
            rafita_Ragdoll.colicion_Rafita = true;
            Collider_Puntos.SetActive(false);
            juego.puntos++;
            juego.txtpuntos.text = juego.puntos_Max + "/" + juego.puntos.ToString();

        }

        if (juego.puntos >= juego.puntos_Max)
        {
 juego.Regresa.gameObject.SetActive(true);
        }
    }
}
