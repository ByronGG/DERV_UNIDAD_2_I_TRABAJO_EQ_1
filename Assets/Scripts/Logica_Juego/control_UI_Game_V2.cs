using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class control_UI_Game_V2 : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI txt_nombre;
    [SerializeField]
    TextMeshProUGUI txt_tiempo; //añadido por inspector

    public void cambiarEscena(int index_escena)
    {
        Scene scene = SceneManager.GetActiveScene();

        if(scene.buildIndex == 0) //escena inicio
        {
            string nombre = txt_nombre.text;
            PlayerPrefs.SetString("nom_usuario", nombre);
        }

        SceneManager.LoadScene(index_escena);
    }

    private void Start()
    {
        //Siempre lee el nombre del usuario
        string n = PlayerPrefs.GetString("nom_usuario", "");
        if (!n.Equals(""))
        {
            Debug.Log("El nombre del usuario es: " + n);
        }
        //asigna el nombre del usuario del componente TMP
        Scene scene = SceneManager.GetActiveScene();

        if (scene.buildIndex == 2) //escena inicio
        {
            string nombre = PlayerPrefs.GetString("nom_usuario", "");
            txt_nombre.text = nombre;

            string tiempo = PlayerPrefs.GetString("Score", "");
            txt_tiempo.text = tiempo;
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.buildIndex == 1)
            //Solo cambiara de escena cuando la escena actual sea la del juego
            {
                cambiarEscena(2);
            }

        }
    }

}
