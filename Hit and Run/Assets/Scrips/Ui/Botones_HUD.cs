using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones_HUD : MonoBehaviour
{
    public GameObject Jugador;
    public GameObject Punto_Reaparicion;
    public string SiguienteNivel;
    public string NivelActual;


    public Player reinicio;

    public void Debug_Nivel()
    {
        SceneManager.LoadScene(NivelActual);
    }
    public void reposicion()
    {
        reinicio.reinicio();
        Jugador.transform.position = Punto_Reaparicion.transform.position;
        Jugador.transform.rotation = Punto_Reaparicion.transform.rotation;
    }
    public void cambioNivel()
    {
        SceneManager.LoadScene(SiguienteNivel);
    }

}
