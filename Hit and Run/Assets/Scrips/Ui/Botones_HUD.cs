using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones_HUD : MonoBehaviour
{
    public GameObject Jugador;
    public GameObject Punto_Reaparicion;

    public Player reinicio;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void reposicion()
    {
        print("xd");
        reinicio.reinicio();
        Jugador.transform.position = Punto_Reaparicion.transform.position;
        Jugador.transform.rotation = Punto_Reaparicion.transform.rotation;
    }
}
