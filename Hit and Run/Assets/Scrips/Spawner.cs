using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public GameObject Punto_de_respawn;
    void Start()
    {
        Instantiate(prefab, Punto_de_respawn.transform.position, new Quaternion(0,0,0,0));
    }

}
