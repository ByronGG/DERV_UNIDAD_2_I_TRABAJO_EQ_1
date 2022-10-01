using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class control_UI_Game : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI txt_nombre;

    public void cambiarEscena(int index_escena)
    {
        string nombre = txt_nombre.text;
        PlayerPrefs.SetString("nom_usuario", nombre);

        SceneManager.LoadScene(index_escena);
    }

    private void Start()
    {
        string n = PlayerPrefs.GetString("nom_usuario", "");
        if (n.Equals(""))
        {
            Debug.Log("El nombre del usuario es: " + n);
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
