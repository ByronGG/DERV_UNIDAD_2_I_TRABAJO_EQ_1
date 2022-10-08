using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Colissiones_Destroy_V2 : MonoBehaviour
{
    [SerializeField]
    GameObject ref_handler_spawns; //inspector
    Manager_Spawns control_manager_spawns; //getcomponent


    [SerializeField]
    TextMeshProUGUI texto_tiempo; //se vincula desde inspector

    //Código tarea de puntaje
    public GameObject Objscore; //Se crea el objeto que guardara el score del juegador
    public float Score; //Valor de puntos que se le da desde el inspector 


    [SerializeField]
    int con_objetos_comidos;
    [SerializeField]
    int tot_objetos_a_comer = 10;
    [SerializeField]
    GameObject referencia_to_HanlerUI; // se vincula desde inspector
    control_UI_Game_V2 componente_control_UI; //se obtiene atravez de getcomponent

    // Start is called before the first frame update
    void Start()
    {
        con_objetos_comidos = 0;
        componente_control_UI = referencia_to_HanlerUI.GetComponent<control_UI_Game_V2>();
        //agregado para la version 2
        control_manager_spawns = ref_handler_spawns.GetComponent<Manager_Spawns>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter (Collision collision)
    {
        string name = collision.gameObject.name;
        string tag = collision.gameObject.tag;

        if (tag.Equals("Enemigo_TAG")) //Si colisiona con un enemigo entonces...
        {
            GameObject obj_a_destruir;
            obj_a_destruir = GameObject.Find(name);

            if(obj_a_destruir != null)
            {
                //Objscore hereda el componente de la clase puntaje y se le da el valor de este con el atributo score
                Objscore.GetComponent<Puntaje>().puntos += Score;


                //Destruye el objeto 5 segundo despues de colisionar con el
                //Destroy(obj_a_destruir, 5);
                Destroy(obj_a_destruir); //Destruye inmediatamente
                Debug.Log("Mamo el enemigo");
                con_objetos_comidos++;

                if(con_objetos_comidos == tot_objetos_a_comer)
                {
                    string tiempo = texto_tiempo.text;
                    PlayerPrefs.SetString("Score", tiempo);
                    //Se acaba el juego
                    componente_control_UI.cambiarEscena(2);
                }

                control_manager_spawns.crearEnemigo();
            }
        }
    }   
}
