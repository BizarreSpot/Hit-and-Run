using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botones_HUD : MonoBehaviour
{
    public GameObject Jugador;
    public GameObject Punto_Reaparicion;

    public Player reinicio;

    public void Debug_Nivel()
    {
        SceneManager.LoadScene("Debug");
    }
    public void reposicion()
    {
        reinicio.reinicio();
        Jugador.transform.position = Punto_Reaparicion.transform.position;
        Jugador.transform.rotation = Punto_Reaparicion.transform.rotation;
    }
}
