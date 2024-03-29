using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garaje : MonoBehaviour
{
    // Start is called before the first frame update
    public Sistema_Juego Juego_Estado;
    public Player Jugador_Estado;
    void OnTriggerEnter(Collider obj)
    {
        if (Juego_Estado.ganar)
        {
            if (obj.gameObject.tag == "Jugador")
            {
                Juego_Estado.tiempo_delta = 0f;
                Jugador_Estado.Ganar = true;
                Jugador_Estado.Iniciar = false;
                Juego_Estado.Pantalla_Ganar.SetActive(true);
            }
        }
    }
}
