using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S_Enemigo_Triggers : MonoBehaviour
{
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

    private void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name;
        string tag = other.gameObject.tag;
        Debug.Log("Entra Trigger. TAG:" + tag + " NAME:" + name);
    }

    private void OnTriggerStay(Collider other)
    {
        string name = other.gameObject.name;
        string tag = other.gameObject.tag;
        Debug.Log("Permanece Trigger. TAG:" + tag + " NAME:" + name);
    }

    private void OnTriggerExit(Collider other)
    {
        string name = other.gameObject.name;
        string tag = other.gameObject.tag;
        Debug.Log("Termina Trigger. TAG:" + tag + " NAME:" + name);
    }
}