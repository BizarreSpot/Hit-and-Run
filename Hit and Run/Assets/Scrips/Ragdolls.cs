using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdolls : MonoBehaviour
{
    [SerializeField] private Animator animador;
    private Rigidbody[] rigidbodies;

    public bool colicion_Rafita;
    void Start()
    {
        rigidbodies = transform.GetComponentsInChildren<Rigidbody>();
        SetEnabled(false);
        colicion_Rafita = false;
    }

    // Update is called once per frame

    void SetEnabled(bool enabled)
    {
        bool isKinematic = !enabled;
        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = isKinematic;
        }

        animador.enabled = !enabled;
    }

    void Update()
    {
     
        if (colicion_Rafita)
        {
            SetEnabled(true);
        }
    }
}
