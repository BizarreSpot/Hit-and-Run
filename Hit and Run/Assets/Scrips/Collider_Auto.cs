using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Auto : MonoBehaviour
{
    // Start is called before the first frame update
    public Player Jugador;
    void OnTriggerEnter(Collider obj)
    {

        if (obj.gameObject.tag == "Pared")
        {
            Jugador.Iniciar = false;
            Jugador.perdiste = true;
        }
    }
}
