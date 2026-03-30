using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creadorEnemigosD : MonoBehaviour
{
    public GameObject enemigo;
    public float tiempo = 3.0f;
    public Transform[] posicionD;
    void Start()
    {
        StartCoroutine(Generar());
    }

    IEnumerator Generar() {
        while (true)
        {
            Cenemigos();
            yield return new WaitForSeconds(tiempo);
        }
    }
       
     void Cenemigos(){
        if (enemigo == null || posicionD.Length == 0) {
            return;
        }
        Transform punto = posicionD[Random.Range(0, posicionD.Length)];
        Instantiate(enemigo, punto.position, punto.rotation);
      }
        
 }

