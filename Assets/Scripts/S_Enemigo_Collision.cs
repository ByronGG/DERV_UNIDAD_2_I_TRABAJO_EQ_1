using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S_Enemigo_Collision : MonoBehaviour
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

    private void OnCollisionEnter(Collision collision)
    {
        string name = collision.gameObject.name;
        string tag = collision.gameObject.tag;
        Debug.Log("Entra en colision. TAG: " + tag + "NAME: " + name);
    }

    private void OnCollisionStay(Collision collision)
    {
        string name = collision.gameObject.name;
        string tag = collision.gameObject.tag;
        Debug.Log("Esta en colision. TAG: " + tag + "NAME: " + name);
    }

    private void OnCollisionExit(Collision collision)
    {
        string name = collision.gameObject.name;
        string tag = collision.gameObject.tag;
        Debug.Log("salio en colision. TAG: " + tag + "NAME: " + name);
    }
}
