using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S_Jugador : MonoBehaviour
{
    int temporal;
    [SerializeField]
    TextMeshProUGUI vida;
    [SerializeField]
    TextMeshProUGUI ataque;

    // Start is called before the first frame update
    void Start()
    {
        int v_vida = Singleton_DatosJugador.datos_jugador.vida;
        int v_ataque = Singleton_DatosJugador.datos_jugador.ataque;

        vida.text = v_vida.ToString();
        ataque.text = v_ataque.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}