using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarEnemigos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemigo"){
            print("eliminar");
            Destroy(collision.transform.root.gameObject);

            ContadorEnemigos.EnemigosEliminados();//Hacer referencia al metodo de ContadorEnemigos
        }
    }
}

