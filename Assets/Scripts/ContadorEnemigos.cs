using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ContadorEnemigos : MonoBehaviour
{
    public static int contEnemy = 0;
    
    public static void EnemigosEliminados(){

        contEnemy++;
    }

    public TextMeshProUGUI texto;

        private void Update()
    {
        texto.text = "EemigosEliminados: " + contEnemy.ToString();
    }
}
