using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private float deltaM = .01f;
    private float VelocidadInicial = 0f;


    private int Direccion = 0;

    private float Turbo = 1;


    private float deltaM_Llanta = .01f;
    private float VelocidadInicial_Llanta = 0f;
    private int Direccion_Llanta = 0;

    public GameObject LlantasF;
    public GameObject LlantasA;

    public bool Iniciar = false;
    public bool perdiste = false;
    public bool Ganar = false;
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            Iniciar = true;
        }

        VelocidadInicial += deltaM;
        transform.Translate(Vector3.Lerp(new Vector3(0, 0, 0), new Vector3(0, 0, Direccion * Turbo), VelocidadInicial) * Time.deltaTime);

        if (!Iniciar)
        {


            if (VelocidadInicial >= 0f)
            {
                deltaM = -0.1f;
            }

            if (VelocidadInicial <= 0f)
            {
                VelocidadInicial = 0f;
            }
        }

        if (!perdiste)
        {
            if (!Ganar)
            {
                if (Iniciar)
                {

                    Direccion = 10;
                    if (VelocidadInicial <= 0f)
                    {
                        deltaM = 0.01f;
                    }

                    if (VelocidadInicial >= 1f)
                    {
                        deltaM = 0;
                    }

                    Rotate();
                    LlantasF.transform.Rotate(Vector3.Lerp(new Vector3(0, 0, 0), new Vector3(Direccion * Turbo * 65, 0, 0), VelocidadInicial) * Time.deltaTime);
                    LlantasA.transform.Rotate(Vector3.Lerp(new Vector3(0, 0, 0), new Vector3(Direccion * Turbo * 65, 0, 0), VelocidadInicial) * Time.deltaTime);
                }
            }
        }

        void Rotate()
        {


            VelocidadInicial_Llanta += deltaM_Llanta;
            transform.Rotate(Vector3.Lerp(new Vector3(0, 0, 0), new Vector3(0, Direccion_Llanta, 0), VelocidadInicial_Llanta) * Time.deltaTime);

            if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            {


                if (VelocidadInicial_Llanta >= 0f)
                {
                    deltaM_Llanta = -.1f;
                }

                if (VelocidadInicial_Llanta <= 0f)
                {
                    VelocidadInicial_Llanta = 0f;
                }

            }

            if (Input.GetKey(KeyCode.D))
            {

                Direccion_Llanta = 100;
                if (VelocidadInicial_Llanta <= 0f)
                {
                    deltaM_Llanta = .01f;
                }

                if (VelocidadInicial_Llanta >= 1f)
                {
                    deltaM_Llanta = 0;
                }
            }

            if (Input.GetKey(KeyCode.A))
            {
                Direccion_Llanta = -100;
                if (VelocidadInicial_Llanta <= 0f)
                {
                    deltaM_Llanta = .01f;
                }

                if (VelocidadInicial_Llanta >= 1f)
                {
                    deltaM_Llanta = 0;
                }
            }

        }


    }

   public void reinicio()
    {
        Iniciar = false;
        perdiste = false;
        Ganar = false;
}

}
