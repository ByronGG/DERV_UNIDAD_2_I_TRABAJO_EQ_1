using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton_DatosJugador : MonoBehaviour
{
    public static Singleton_DatosJugador datos_jugador;

    public int vida;
    public int ataque;

    private void Awake()
    {
        if (datos_jugador == null)
        {
            vida = 100;
            ataque = 25;
            datos_jugador = this;
        }
        else //cuando no sea null
        {
            Destroy(this);
            //Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}