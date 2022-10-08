using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] //Para que el campo se vea desde el inspector
    GameObject aquien_instanciar;
    [SerializeField]
    GameObject spawn;


    // Start is called before the first frame update
    void Start()
    {
        contadorEnemigosCreados = 0;
    }

    int contadorEnemigosCreados;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            //Requisitos:
            //Aquien se va instanciar
            //Donde va a instanciar


            GameObject objClonado;
            objClonado = Instantiate(aquien_instanciar,
                spawn.transform.position, spawn.transform.rotation);
            objClonado.name = "Enemigo_" + contadorEnemigosCreados;
            objClonado.tag = "Enemigo_TAG";
            contadorEnemigosCreados++;
        }
    }
}
