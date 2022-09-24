using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; //Importar libreria de audios

public class Trigger_Sound : MonoBehaviour
{
    //Atributos
    public AudioSource audioSource;
    public AudioClip musica;
    [Range(0, 10)]public float volumen;
    bool playMusicOnce = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (playMusicOnce == false)
        {
            audioSource.PlayOneShot(musica, volumen);
            playMusicOnce = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {

    }
}
