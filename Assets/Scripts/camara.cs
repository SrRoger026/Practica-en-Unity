using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class camara : MonoBehaviour
{
    //public AudioSource musica;
    public Transform personaje;
    Vector3 posicion;
    public float velocidadCamara = 0.50f;
    Vector3 fueraCamara;
    float yFija;
    public float minX;
    public float minY;
    void Start()
    {
        //posicion = transform.position - personaje.position
        //musica.Play();
        fueraCamara = transform.position - personaje.position;
        yFija = transform.position.y;
    }

    private void LateUpdate()
    {
        float objetivo = personaje.position.x + fueraCamara.x;
        objetivo = Mathf.Clamp(objetivo, minX, minY);
        Vector3 objetivoX = new Vector3(
            objetivo,
            yFija,
            transform.position.z);
        transform.position = Vector3.Lerp(transform.position,
            objetivoX,
            velocidadCamara * Time.deltaTime);
    }
}
