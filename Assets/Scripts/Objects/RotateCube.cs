using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private Vector3 direccion;
    private float velocidad;

    void Start()
    {
        direccion = new Vector3(Random.value, Random.value, Random.value);
        velocidad = Random.Range(20f, 60f);
    }

    void Update()
    {
        transform.Rotate(direccion * velocidad * Time.deltaTime);
    }
}
