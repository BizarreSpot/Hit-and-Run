using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rafita : MonoBehaviour
{
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
            print("choco");
            juego.puntos++;
            juego.txtpuntos.text = juego.puntos_Max + "/" + juego.puntos.ToString(); ;
            if (juego.puntos >= juego.puntos_Max)
            {
                juego.Pantalla_Ganar.SetActive(true);
                juego.txtpuntos.text = "WIN";
            }
        }
    }

}
